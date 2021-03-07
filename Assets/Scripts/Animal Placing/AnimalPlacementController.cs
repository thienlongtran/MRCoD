using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(ARRaycastManager))]

public class AnimalPlacementController : MonoBehaviour
{
    [SerializeField]
    GameObject cat;

    [SerializeField]
    GameObject chicken;

    [SerializeField]
    private Camera arCamera;

    [SerializeField]
    Button catButton;

    [SerializeField]
    Button chickenButton;

    private ARPlaneManager aRPlaneManager;
    private ARRaycastManager aRRaycastManager;

    GameObject placedCat;
    GameObject placedChicken;

    bool catIsPlaced;
    bool chickenIsPlaced;

    bool catIsCollected;
    bool chickenIsCollected;


    void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
        aRPlaneManager = GetComponent<ARPlaneManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        catIsPlaced = false;
        chickenIsPlaced = false;

        catIsCollected = false;
        chickenIsCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var plane in aRPlaneManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }

        
        if (catIsPlaced == false)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedCat = Instantiate(cat, hitPose.position, Quaternion.Euler(hitPose.rotation.x, 180.0f, hitPose.rotation.z));
                    DistanceText.t = "cat";
                    catIsPlaced = true;
                    catButton.gameObject.SetActive(true);
                }
            }
        }

        if(chickenIsPlaced == false && catIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedChicken = Instantiate(chicken, hitPose.position, Quaternion.Euler(hitPose.rotation.x, 180.0f, hitPose.rotation.z));
                    DistanceText.t = "chick";
                    chickenIsPlaced = true;
                    chickenButton.gameObject.SetActive(true);
                }
            }
        }
    }


    public void collectCat()
    {
        Destroy(placedCat);
        catIsCollected = true;
        catButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectChicken()
    {
        Destroy(placedChicken);
        chickenIsCollected = true;
        chickenButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
        SceneManager.LoadScene("OrderOfplay");
    }


    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
}
