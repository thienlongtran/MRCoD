using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ARRaycastManager))]

public class ShelterPlacementController : MonoBehaviour
{
    [SerializeField]
    GameObject chickCoop;

    [SerializeField]
    GameObject basket;

    [SerializeField]
    GameObject house;

    [SerializeField]
    GameObject cloth;

    [SerializeField]
    GameObject cage;



    [SerializeField]
    Button chickCoopButton;

    [SerializeField]
    Button basketButton;

    [SerializeField]
    Button houseButton;

    [SerializeField]
    Button clothButton;

    [SerializeField]
    Button cageButton;


    private ARPlaneManager aRPlaneManager;
    private ARRaycastManager aRRaycastManager;

    GameObject placedChickCoop;
    GameObject placedBasket;
    GameObject placedHouse;
    GameObject placedCloth;
    GameObject placedCage;

    bool chickCoopIsPlaced;
    bool basketIsPlaced;
    bool houseIsPlaced;
    bool clothIsPlaced;
    bool cageIsPlaced;

    public static bool chickCoopIsCollected;
    public static bool basketIsCollected;
    public static bool houseIsCollected;
    public static bool clothIsCollected;
    public static bool cageIsCollected;


    void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
        aRPlaneManager = GetComponent<ARPlaneManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        chickCoopIsPlaced = false;
        basketIsPlaced = false;
        houseIsPlaced = false;
        clothIsPlaced = false;
        cageIsPlaced = false;

        chickCoopIsCollected = false;
        basketIsCollected = false;
        houseIsCollected = false;
        clothIsCollected = false;
        cageIsCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var plane in aRPlaneManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }

        if (chickCoopIsPlaced == false)
        {
            if (CameraPosition.distance > 3)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedChickCoop = Instantiate(chickCoop, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "chickCoop";
                    chickCoopIsPlaced = true;
                    chickCoopButton.gameObject.SetActive(true);
                }
            }
        }

        if (basketIsPlaced == false && chickCoopIsCollected == true)
        {
            if (CameraPosition.distance > 5)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedBasket = Instantiate(basket, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "basket";
                    basketIsPlaced = true;
                    basketButton.gameObject.SetActive(true);
                }
            }
        }

        if (houseIsPlaced == false && basketIsCollected == true)
        {
            if (CameraPosition.distance > 9)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedHouse = Instantiate(house, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.x, hitPose.rotation.z));
                    DistanceText.t = "house";
                    houseIsPlaced = true;
                    houseButton.gameObject.SetActive(true);
                }
            }
        }

        if (clothIsPlaced == false && houseIsCollected == true)
        {
            if (CameraPosition.distance > 4)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedCloth = Instantiate(cloth, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "cloth";
                    clothIsPlaced = true;
                    clothButton.gameObject.SetActive(true);
                }
            }
        }

        if (cageIsPlaced == false && clothIsCollected == true)
        {
            if (CameraPosition.distance > 6)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedCage = Instantiate(cage, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "cage";
                    cageIsPlaced = true;
                    cageButton.gameObject.SetActive(true);
                }
            }
        }
    }

    public void collectChickCoop()
    {
        Destroy(placedChickCoop);
        chickCoopIsCollected = true;
        chickCoopButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectBasket()
    {
        Destroy(placedBasket);
        basketIsCollected = true;
        basketButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectHouse()
    {
        Destroy(placedHouse);
        houseIsCollected = true;
        houseButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectCloth()
    {
        Destroy(placedCloth);
        clothIsCollected = true;
        clothButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectCage()
    {
        Destroy(placedCage);
        cageIsCollected = true;
        cageButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
        SceneManager.LoadScene("MatchShelterScene");
    }


    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
}
