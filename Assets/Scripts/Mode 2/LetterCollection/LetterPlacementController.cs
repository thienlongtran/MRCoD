using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ARRaycastManager))]

public class LetterPlacementController : MonoBehaviour
{
    [SerializeField]
    GameObject a;

    [SerializeField]
    GameObject c;

    [SerializeField]
    GameObject d;

    [SerializeField]
    GameObject e;

    [SerializeField]
    GameObject f;

    [SerializeField]
    GameObject l;

    [SerializeField]
    GameObject o;

    [SerializeField]
    GameObject r;

    [SerializeField]
    GameObject t;

    [SerializeField]
    GameObject v;


    [SerializeField]
    Button aButton;

    [SerializeField]
    Button cButton;

    [SerializeField]
    Button dButton;

    [SerializeField]
    Button eButton;

    [SerializeField]
    Button fButton;

    [SerializeField]
    Button lButton;

    [SerializeField]
    Button oButton;

    [SerializeField]
    Button rButton;

    [SerializeField]
    Button tButton;

    [SerializeField]
    Button vButton;


    private ARPlaneManager aRPlaneManager;
    private ARRaycastManager aRRaycastManager;


    GameObject placedA;
    GameObject placedC;
    GameObject placedD;
    GameObject placedE;
    GameObject placedF;
    GameObject placedL;
    GameObject placedO;
    GameObject placedR;
    GameObject placedT;
    GameObject placedV;

    bool aIsPlaced;
    bool cIsPlaced;
    bool dIsPlaced;
    bool eIsPlaced;
    bool fIsPlaced;
    bool lIsPlaced;
    bool oIsPlaced;
    bool rIsPlaced;
    bool tIsPlaced;
    bool vIsPlaced;

    public static bool aIsCollected;
    public static bool cIsCollected;
    public static bool dIsCollected;
    public static bool eIsCollected;
    public static bool fIsCollected;
    public static bool lIsCollected;
    public static bool oIsCollected;
    public static bool rIsCollected;
    public static bool tIsCollected;
    public static bool vIsCollected;

    void Awake()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
        aRPlaneManager = GetComponent<ARPlaneManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        aIsPlaced = false;
        cIsPlaced = false;
        dIsPlaced = false;
        eIsPlaced = false;
        fIsPlaced = false;

        aIsCollected = false;
        cIsCollected = false;
        dIsCollected = false;
        eIsCollected = false;
        fIsCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var plane in aRPlaneManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }

        if (aIsPlaced == false)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedA = Instantiate(a, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "a";
                    aIsPlaced = true;
                    aButton.gameObject.SetActive(true);
                }
            }
        }

        if (cIsPlaced == false && aIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedC = Instantiate(c, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "c";
                    cIsPlaced = true;
                    cButton.gameObject.SetActive(true);
                }
            }
        }

        if (dIsPlaced == false && cIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedD = Instantiate(d, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.x, hitPose.rotation.z));
                    DistanceText.t = "d";
                    dIsPlaced = true;
                    dButton.gameObject.SetActive(true);
                }
            }
        }

        if (eIsPlaced == false && dIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedE = Instantiate(e, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "e";
                    eIsPlaced = true;
                    eButton.gameObject.SetActive(true);
                }
            }
        }

        if (fIsPlaced == false && eIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedF = Instantiate(f, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "f";
                    fIsPlaced = true;
                    fButton.gameObject.SetActive(true);
                }
            }
        }

        if (lIsPlaced == false && fIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedL = Instantiate(l, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "l";
                    lIsPlaced = true;
                    lButton.gameObject.SetActive(true);
                }
            }
        }

        if (oIsPlaced == false && lIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedO = Instantiate(o, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "o";
                    oIsPlaced = true;
                    oButton.gameObject.SetActive(true);
                }
            }
        }

        if (rIsPlaced == false && oIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedR = Instantiate(r, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "r";
                    rIsPlaced = true;
                    rButton.gameObject.SetActive(true);
                }
            }
        }

        if (tIsPlaced == false && rIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedT = Instantiate(t, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "f";
                    tIsPlaced = true;
                    tButton.gameObject.SetActive(true);
                }
            }
        }

        if (vIsPlaced == false && tIsCollected == true)
        {
            if (CameraPosition.distance > 1)
            {
                if (aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    placedV = Instantiate(v, hitPose.position, Quaternion.Euler(hitPose.rotation.x, hitPose.rotation.y, hitPose.rotation.z));
                    DistanceText.t = "v";
                    vIsPlaced = true;
                    vButton.gameObject.SetActive(true);
                }
            }
        }
    }

    public void collectA()
    {
        Destroy(placedA);
        aIsCollected = true;
        aButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectC()
    {
        Destroy(placedC);
        cIsCollected = true;
        cButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectD()
    {
        Destroy(placedD);
        dIsCollected = true;
        dButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectE()
    {
        Destroy(placedE);
        eIsCollected = true;
        eButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectF()
    {
        Destroy(placedF);
        fIsCollected = true;
        fButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectL()
    {
        Destroy(placedL);
        lIsCollected = true;
        lButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectO()
    {
        Destroy(placedO);
        oIsCollected = true;
        oButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectR()
    {
        Destroy(placedR);
        rIsCollected = true;
        rButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectT()
    {
        Destroy(placedT);
        tIsCollected = true;
        tButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
    }

    public void collectV()
    {
        Destroy(placedV);
        vIsCollected = true;
        vButton.gameObject.SetActive(false);
        CameraPosition.distance = 0;
        SceneManager.LoadScene("CreateWord");
    }

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
}

