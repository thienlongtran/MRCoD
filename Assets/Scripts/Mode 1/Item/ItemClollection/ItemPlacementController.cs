using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ARRaycastManager))]

public class ItemPlacementController : MonoBehaviour
{
    [SerializeField]
    GameObject wool;

    [SerializeField]
    GameObject knife;

    [SerializeField]
    GameObject egg;

    [SerializeField]
    GameObject leg;

    [SerializeField]
    GameObject toy;



    [SerializeField]
    Button woolButton;

    [SerializeField]
    Button knifeButton;

    [SerializeField]
    Button eggButton;

    [SerializeField]
    Button legButton;

    [SerializeField]
    Button toyButton;


    private ARPlaneManager aRPlaneManager;
    private ARRaycastManager aRRaycastManager;

    GameObject placedWool;
    GameObject placedKnife;
    GameObject placedEgg;
    GameObject placedLeg;
    GameObject placedToy;

    bool woolIsPlaced;
    bool knifeIsPlaced;
    bool eggIsPlaced;
    bool legIsPlaced;
    bool toyIsPlaced;

    public static bool woolIsCollected;
    public static bool knifeIsCollected;
    public static bool eggIsCollected;
    public static bool legIsCollected;
    public static bool toyIsCollected;


    void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
        aRPlaneManager = GetComponent<ARPlaneManager>();
    }

    // Start is called before the first frame update
    void Start()
    {

        woolIsPlaced = false;
        knifeIsPlaced = false;
        eggIsPlaced = false;
        legIsPlaced = false;
        toyIsPlaced = false;

        woolIsCollected = false;
        knifeIsCollected = false;
        eggIsCollected = false;
        legIsCollected = false;
        toyIsCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var plane in aRPlaneManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }

        if (woolIsPlaced == false)
        {
            if (CameraPosition.distance > 5)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedWool = Instantiate(wool, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "wool";
                    woolIsPlaced = true;
                    woolButton.gameObject.SetActive(true);
                }
            }
        }

        if (knifeIsPlaced == false && woolIsCollected == true)
        {
            if (CameraPosition.distance > 6)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedKnife = Instantiate(knife, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "knife";
                    knifeIsPlaced = true;
                    knifeButton.gameObject.SetActive(true);
                }
            }
        }

        if (eggIsPlaced == false && knifeIsCollected == true)
        {
            if (CameraPosition.distance > 4)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedEgg = Instantiate(egg, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.x, hitPose.rotation.z));
                    DistanceText.t = "egg";
                    eggIsPlaced = true;
                    eggButton.gameObject.SetActive(true);
                }
            }
        }

        if (legIsPlaced == false && eggIsCollected == true)
        {
            if (CameraPosition.distance > 9)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedLeg = Instantiate(leg, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "leg";
                    legIsPlaced = true;
                    legButton.gameObject.SetActive(true);
                }
            }
        }

        if (toyIsPlaced == false && legIsCollected == true)
        {
            if (CameraPosition.distance > 2)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedToy = Instantiate(toy, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "toy";
                    toyIsPlaced = true;
                    toyButton.gameObject.SetActive(true);
                }
            }
        }
    }

    public void collectwool()
    {
        Destroy(placedWool);
        woolIsCollected = true;
        woolButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectknife()
    {
        Destroy(placedKnife);
        knifeIsCollected = true;
        knifeButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectegg()
    {
        Destroy(placedEgg);
        eggIsCollected = true;
        eggButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectleg()
    {
        Destroy(placedLeg);
        legIsCollected = true;
        legButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collecttoy()
    {
        Destroy(placedToy);
        toyIsCollected = true;
        toyButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
        SceneManager.LoadScene("MatchItem");
    }




    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
}
