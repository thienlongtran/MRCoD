using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ARRaycastManager))]

public class FoodPlacementController : MonoBehaviour
{
    [SerializeField]
    GameObject milk;

    [SerializeField]
    GameObject ant;

    [SerializeField]
    GameObject grass;

    [SerializeField]
    GameObject orange;

    [SerializeField]
    GameObject fish;



    [SerializeField]
    Button milkButton;

    [SerializeField]
    Button antButton;

    [SerializeField]
    Button grassButton;

    [SerializeField]
    Button orangeButton;

    [SerializeField]
    Button fishButton;


    private ARPlaneManager aRPlaneManager;
    private ARRaycastManager aRRaycastManager;

    GameObject placedMilk;
    GameObject placedAnt;
    GameObject placedGrass;
    GameObject placedOrange;
    GameObject placedFish;

    bool milkIsPlaced;
    bool antIsPlaced;
    bool grassIsPlaced;
    bool orangeIsPlaced;
    bool fishIsPlaced;

    public static bool milkIsCollected;
    public static bool antIsCollected;
    public static bool grassIsCollected;
    public static bool orangeIsCollected;
    public static bool fishIsCollected;


    void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
        aRPlaneManager = GetComponent<ARPlaneManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
       // milk.transform.localScale = new Vector3(0.13f, 0.13f, 0.13f);
       // ant.transform.localScale = new Vector3(10f, 10f, 10f);
        grass.transform.localScale = new Vector3(2f, 2f, 2f);
       // orange.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
       // fish.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

        milkIsPlaced = false;
        antIsPlaced = false;
        grassIsPlaced = false;
        orangeIsPlaced = false;
        fishIsPlaced = false;

        milkIsCollected = false;
        antIsCollected = false;
        grassIsCollected = false;
        orangeIsCollected = false;
        fishIsCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var plane in aRPlaneManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }

        if (milkIsPlaced == false)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedMilk = Instantiate(milk, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "milk";
                    milkIsPlaced = true;
                    milkButton.gameObject.SetActive(true);
                }
            }
        }

        if (antIsPlaced == false && milkIsCollected == true)
        {
            if (CameraPosition.distance > 5)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedAnt = Instantiate(ant, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "ant";
                    antIsPlaced = true;
                    antButton.gameObject.SetActive(true);
                }
            }
        }

        if (grassIsPlaced == false && antIsCollected == true)
        {
            if (CameraPosition.distance > 2)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedGrass = Instantiate(grass, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.x, hitPose.rotation.z));
                    DistanceText.t = "grass";
                    grassIsPlaced = true;
                    grassButton.gameObject.SetActive(true);
                }
            }
        }

        if (orangeIsPlaced == false && grassIsCollected == true)
        {
            if (CameraPosition.distance > 4)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedOrange = Instantiate(orange, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "orange";
                    orangeIsPlaced = true;
                    orangeButton.gameObject.SetActive(true);
                }
            }
        }

        if (fishIsPlaced == false && orangeIsCollected == true)
        {
            if (CameraPosition.distance > 9)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedFish = Instantiate(fish, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "fish";
                    fishIsPlaced = true;
                    fishButton.gameObject.SetActive(true);
                }
            }
        }
    }

    public void collectMilk()
    {
        Destroy(placedMilk);
        milkIsCollected = true;
        milkButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectAnt()
    {
        Destroy(placedAnt);
        antIsCollected = true;
        antButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectGrass()
    {
        Destroy(placedGrass);
        grassIsCollected = true;
        grassButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectOrange()
    {
        Destroy(placedOrange);
        orangeIsCollected = true;
        orangeButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectFish()
    {
        Destroy(placedFish);
        fishIsCollected = true;
        fishButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
        SceneManager.LoadScene("MatchFoodScene");
    }




    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
}
