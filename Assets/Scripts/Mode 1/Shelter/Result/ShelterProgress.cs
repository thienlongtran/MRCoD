using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelterProgress : MonoBehaviour
{
    public static float catShelter;
    public static float chickenShelter;

    public static float catShelterTotal;
    public static float chickenShelterTotal;

    public static int catShelterPerformance;
    public static int chickenShelterPerformance;

    // Start is called before the first frame update
    void Start()
    {
        catShelter = 0.0f;
        chickenShelter = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        catShelterTotal = (catShelter / 1.9f) * 100.0f;
        chickenShelterTotal = (chickenShelter / 1.9f) * 100.0f;


        if (catShelterTotal > 100)
        {
            catShelterTotal = 100;
        }

        if (chickenShelterTotal > 100)
        {
            chickenShelterTotal = 100;
        }


        if (catShelterTotal > 66)
        {
            catShelterPerformance = 3;//good
        }
        else if (catShelterTotal > 33)
        {
            catShelterPerformance = 2;//moderate
        }
        else
        {
            catShelterPerformance = 1;//bad
        }

        if (chickenShelterTotal > 66)
        {
            chickenShelterPerformance = 3;//good
        }
        else if (chickenShelterTotal > 33)
        {
            chickenShelterPerformance = 2;//moderate
        }
        else
        {
            chickenShelterPerformance = 1;//bad
        }
    }
}
