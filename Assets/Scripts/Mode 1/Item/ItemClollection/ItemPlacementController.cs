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


    [SerializeField]
    Camera arCamera;
    Vector3 screenCenter;

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

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
        aRPlaneManager = GetComponent<ARPlaneManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        screenCenter = new Vector3(arCamera.pixelWidth / 2, arCamera.pixelHeight / 2, 0f);

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
            if (CameraPosition.distance > 1)
            {
                var ray = arCamera.ScreenPointToRay(screenCenter);
                if (aRRaycastManager.Raycast(ray, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinBounds))
                {
                    var hitPose = hits[0].pose;
                    placedWool = Instantiate(wool, hitPose.position, hitPose.rotation);
                    DistanceText.t = "wool";
                    woolIsPlaced = true;
                    woolButton.gameObject.SetActive(true);
                }
            }
        }

        if (knifeIsPlaced == false && woolIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                var ray = arCamera.ScreenPointToRay(screenCenter);
                if (aRRaycastManager.Raycast(ray, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinBounds))
                {
                    var hitPose = hits[0].pose;
                    placedKnife = Instantiate(knife, hitPose.position, hitPose.rotation);
                    DistanceText.t = "knife";
                    knifeIsPlaced = true;
                    knifeButton.gameObject.SetActive(true);
                }
            }
        }

        if (eggIsPlaced == false && knifeIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                var ray = arCamera.ScreenPointToRay(screenCenter);
                if (aRRaycastManager.Raycast(ray, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinBounds))
                {
                    var hitPose = hits[0].pose;
                    placedEgg = Instantiate(egg, hitPose.position, hitPose.rotation);
                    DistanceText.t = "egg";
                    eggIsPlaced = true;
                    eggButton.gameObject.SetActive(true);
                }
            }
        }

        if (legIsPlaced == false && eggIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                var ray = arCamera.ScreenPointToRay(screenCenter);
                if (aRRaycastManager.Raycast(ray, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinBounds))
                {
                    var hitPose = hits[0].pose;
                    placedLeg = Instantiate(leg, hitPose.position, hitPose.rotation);
                    DistanceText.t = "leg";
                    legIsPlaced = true;
                    legButton.gameObject.SetActive(true);
                }
            }
        }

        if (toyIsPlaced == false && legIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                var ray = arCamera.ScreenPointToRay(screenCenter);
                if (aRRaycastManager.Raycast(ray, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedToy = Instantiate(toy, hitPose.position, hitPose.rotation);
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
    
}
