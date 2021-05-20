using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ARRaycastManager))]

public class Food2PlacementController : MonoBehaviour
{
    [SerializeField]
    GameObject waterMelon;

    [SerializeField]
    GameObject tomato;

    [SerializeField]
    GameObject chickenLeg;

    [SerializeField]
    GameObject coke;

    [SerializeField]
    GameObject corn;



    [SerializeField]
    Button waterMelonButton;

    [SerializeField]
    Button tomatoButton;

    [SerializeField]
    Button chickenLegButton;

    [SerializeField]
    Button cokeButton;

    [SerializeField]
    Button cornButton;


    private ARPlaneManager aRPlaneManager;
    private ARRaycastManager aRRaycastManager;

    GameObject placedWaterMelon;
    GameObject placedTomato;
    GameObject placedChickenLeg;
    GameObject placedCoke;
    GameObject placedCorn;

    bool waterMelonIsPlaced;
    bool tomatoIsPlaced;
    bool chickenLegIsPlaced;
    bool cokeIsPlaced;
    bool cornIsPlaced;

    public static bool waterMelonIsCollected;
    public static bool tomatoIsCollected;
    public static bool chickenLegIsCollected;
    public static bool cokeIsCollected;
    public static bool cornIsCollected;


    void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
        aRPlaneManager = GetComponent<ARPlaneManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        waterMelonIsPlaced = false;
        tomatoIsPlaced = false;
        chickenLegIsPlaced = false;
        cokeIsPlaced = false;
        cornIsPlaced = false;

        waterMelonIsCollected = false;
        tomatoIsCollected = false;
        chickenLegIsCollected = false;
        cokeIsCollected = false;
        cornIsCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var plane in aRPlaneManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }

        if (waterMelonIsPlaced == false)
        {
            if (CameraPosition.distance > 5)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedWaterMelon = Instantiate(waterMelon, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "waterMelon";
                    waterMelonIsPlaced = true;
                    waterMelonButton.gameObject.SetActive(true);
                }
            }
        }

        if (tomatoIsPlaced == false && waterMelonIsCollected == true)
        {
            if (CameraPosition.distance > 5)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedTomato = Instantiate(tomato, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "tomato";
                    tomatoIsPlaced = true;
                    tomatoButton.gameObject.SetActive(true);
                }
            }
        }

        if (chickenLegIsPlaced == false && tomatoIsCollected == true)
        {
            if (CameraPosition.distance > 7)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedChickenLeg = Instantiate(chickenLeg, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.x, hitPose.rotation.z));
                    DistanceText.t = "chickenLeg";
                    chickenLegIsPlaced = true;
                    chickenLegButton.gameObject.SetActive(true);
                }
            }
        }

        if (cokeIsPlaced == false && chickenLegIsCollected == true)
        {
            if (CameraPosition.distance > 9)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedCoke = Instantiate(coke, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "coke";
                    cokeIsPlaced = true;
                    cokeButton.gameObject.SetActive(true);
                }
            }
        }

        if (cornIsPlaced == false && cokeIsCollected == true)
        {
            if (CameraPosition.distance > 4)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedCorn = Instantiate(corn, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "corn";
                    cornIsPlaced = true;
                    cornButton.gameObject.SetActive(true);
                }
            }
        }
    }

    public void collectWaterMelon()
    {
        Destroy(placedWaterMelon);
        waterMelonIsCollected = true;
        waterMelonButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectTomato()
    {
        Destroy(placedTomato);
        tomatoIsCollected = true;
        tomatoButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectChickenLeg()
    {
        Destroy(placedChickenLeg);
        chickenLegIsCollected = true;
        chickenLegButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectCoke()
    {
        Destroy(placedCoke);
        cokeIsCollected = true;
        cokeButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectCorn()
    {
        Destroy(placedCorn);
        cornIsCollected = true;
        cornButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
        SceneManager.LoadScene("MatchFood2");
    }




    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
}
