using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food2Progress : MonoBehaviour
{
    public static float catFood2;
    public static float chickenFood2;

    public static float catFood2Total;
    public static float chickenFood2Total;

    public static int catFood2Performance;
    public static int chickenFood2Performance;
    // Start is called before the first frame update
    void Start()
    {
        catFood2 = 0.0f;
        chickenFood2 = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        catFood2Total = (catFood2 / 1.0f) * 100.0f;
        chickenFood2Total = (chickenFood2 / 3.0f) * 100.0f;


        if (catFood2Total > 100)
        {
            catFood2Total = 100;
        }

        if (chickenFood2Total > 100)
        {
            chickenFood2Total = 100;
        }



        if (catFood2Total > 66)
        {
            catFood2Performance = 3;//good
            BarValue.catHealth = BarValue.catHealth + 2;
        }
        else if (catFood2Total > 33)
        {
            catFood2Performance = 2;//moderate
            BarValue.catHealth++;
        }
        else
        {
            catFood2Performance = 1;//bad
        }



        if (chickenFood2Total > 67)
        {
            chickenFood2Performance = 3;//good
            BarValue.chickenHealth = BarValue.chickenHealth + 2;
        }
        else if (chickenFood2Total > 34)
        {
            chickenFood2Performance = 2;//moderate
            BarValue.chickenHealth++;
        }
        else
        {
            chickenFood2Performance = 1;//bad
        }
    }
}