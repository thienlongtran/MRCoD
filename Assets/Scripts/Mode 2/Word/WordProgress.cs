using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordProgress : MonoBehaviour
{
    public static float catWords;
    public static float chickenWords;

    public static float catWordsTotal;
    public static float chickenWordsTotal;

    public static int catWordsPerformance;
    public static int chickenWordsPerformance;

    // Start is called before the first frame update
    void Start()
    {
        catWords = 0.0f;
        chickenWords = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        catWordsTotal = (catWords / 4.0f) * 100.0f;
        chickenWordsTotal = (chickenWords / 4.0f) * 100.0f;


        if (catWordsTotal > 100)
        {
            catWordsTotal = 100;
        }

        if (chickenWordsTotal > 100)
        {
            chickenWordsTotal = 100;
        }


        if (catWordsTotal > 66)
        {
            catWordsPerformance = 3;//good
            BarValue.catHealth = BarValue.catHealth + 2;
        }
        else if (catWordsTotal > 33)
        {
            catWordsPerformance = 2;//moderate
            BarValue.catHealth++;
        }
        else
        {
            catWordsPerformance = 1;//bad
        }



        if (chickenWordsTotal > 66)
        {
            chickenWordsPerformance = 3;//good
            BarValue.chickenHealth = BarValue.chickenHealth + 2;
        }
        else if (chickenWordsTotal > 33)
        {
            chickenWordsPerformance = 2;//moderate
            BarValue.chickenHealth++;
        }
        else
        {
            chickenWordsPerformance = 1;//bad
        }
    }
}