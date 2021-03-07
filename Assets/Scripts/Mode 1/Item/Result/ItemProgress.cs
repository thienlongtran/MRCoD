using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemProgress : MonoBehaviour
{
    public static float catItem;
    public static float chickenItem;

    public static float catItemTotal;
    public static float chickenItemTotal;

    public static int catItemPerformance;
    public static int chickenItemPerformance;
    // Start is called before the first frame update
    void Start()
    {
        catItem = 0.0f;
        chickenItem = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        catItemTotal = (catItem / 3.0f) * 100.0f;
        chickenItemTotal = (chickenItem / 1.0f) * 100.0f;


        if (catItemTotal > 100)
        {
            catItemTotal = 100;
        }

        if (chickenItemTotal > 100)
        {
            chickenItemTotal = 100;
        }


        if (catItemTotal > 66)
        {
            catItemPerformance = 3;//good
        }
        else if (catItemTotal > 33)
        {
            catItemPerformance = 2;//moderate
        }
        else
        {
            catItemPerformance = 1;//bad
        }

        if (chickenItemTotal > 66)
        {
            chickenItemPerformance = 3;//good
        }
        else if (chickenItemTotal > 33)
        {
            chickenItemPerformance = 2;//moderate
        }
        else
        {
            chickenItemPerformance = 1;//bad
        }
    }
}
