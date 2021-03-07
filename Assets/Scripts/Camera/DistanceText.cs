using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceText : MonoBehaviour
{
    public Text dText;

    public static string t="start";
    // Start is called before the first frame update
    void Start()
    {
        dText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        dText.text = CameraPosition.distance.ToString()+"\n"+t;
       // dText.text = t;
    }
}
