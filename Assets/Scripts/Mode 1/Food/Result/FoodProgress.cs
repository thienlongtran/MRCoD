using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodProgress : MonoBehaviour
{
    public static float catFood;
    public static float chickenFood;

    public static float catFoodTotal;
    public static float chickenFoodTotal;

    public static int catFoodPerformance;
    public static int chickenFoodPerformance;
    // Start is called before the first frame update
    void Start()
    {
        catFood = 0.0f;
        chickenFood = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        catFoodTotal = (catFood/1.9f)*100.0f;
        chickenFoodTotal = (chickenFood/1.9f) * 100.0f;


        if(catFoodTotal>100)
        {
            catFoodTotal = 100;
        }

        if(chickenFoodTotal>100)
        {
            chickenFoodTotal = 100;
        }


        if(catFoodTotal>66)
        {
            catFoodPerformance = 3;//good
        }
        else if(catFoodTotal>33)
        {
            catFoodPerformance = 2;//moderate
        }
        else
        {
            catFoodPerformance = 1;//bad
        }

        if (chickenFoodTotal > 66)
        {
            chickenFoodPerformance = 3;//good
        }
        else if (chickenFoodTotal > 33)
        {
            chickenFoodPerformance = 2;//moderate
        }
        else
        {
            chickenFoodPerformance = 1;//bad
        }
    }
}
