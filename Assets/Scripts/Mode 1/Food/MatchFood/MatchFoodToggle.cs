using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchFoodToggle : MonoBehaviour
{
    public Toggle milkCatToggle;
    public Toggle milkChickToggle;
    public Toggle milkTrashToggle;

    public Toggle antCatToggle;
    public Toggle antChickToggle;
    public Toggle antTrashToggle;

    public Toggle grassCatToggle;
    public Toggle grassChickToggle;
    public Toggle grassTrashToggle;

    public Toggle orangeCatToggle;
    public Toggle orangeChickToggle;
    public Toggle orangeTrashToggle;

    public Toggle fishCatToggle;
    public Toggle fishChickToggle;
    public Toggle fishTrashToggle;

    void Start()
    {

    }

    //cat best = 1.9
    //chick best = 1.9


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Done()
    {
        //milk
        if (milkCatToggle.isOn)
        {
            FoodProgress.catFood = FoodProgress.catFood + 1.0f;

        }

        if (milkChickToggle.isOn)
        {
            FoodProgress.chickenFood = FoodProgress.chickenFood - 1.0f;
        }

        if (milkTrashToggle.isOn)
        {

        }


        //ant
        if (antCatToggle.isOn)
        {
            FoodProgress.catFood = FoodProgress.catFood - 1.0f;
        }

        if (antChickToggle.isOn)
        {
            FoodProgress.chickenFood = FoodProgress.chickenFood + 1.0f;
        }

        if (antTrashToggle.isOn)
        {

        }


        //grass
        if (grassCatToggle.isOn)
        {
            FoodProgress.catFood = FoodProgress.catFood + 0.1f;
        }

        if (grassChickToggle.isOn)
        {
            FoodProgress.chickenFood = FoodProgress.chickenFood + 0.9f;
        }

        if (grassTrashToggle.isOn)
        {

        }


        //orange
        if (orangeCatToggle.isOn)
        {
            FoodProgress.catFood = FoodProgress.catFood - 1.0f;
        }

        if (orangeChickToggle.isOn)
        {
            FoodProgress.chickenFood = FoodProgress.chickenFood - 1.0f;
        }

        if (orangeTrashToggle.isOn)
        {

        }

        //fish
        if (fishCatToggle.isOn)
        {
            FoodProgress.catFood = FoodProgress.catFood + 0.9f;
        }

        if (fishChickToggle.isOn)
        {
            FoodProgress.chickenFood = FoodProgress.chickenFood + 0.1f;
        }

        if (fishTrashToggle.isOn)
        {

        }

        SceneManager.LoadScene("FoodResult");
        //ParcentageControl.foodDone = true;
    }
}
