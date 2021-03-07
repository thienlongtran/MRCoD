using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Match2FoodToggle : MonoBehaviour
{
    public Toggle waterMelonCatToggle;
    public Toggle waterMelonChickToggle;
    public Toggle waterMelonTrashToggle;

    public Toggle tomatoCatToggle;
    public Toggle tomatoChickToggle;
    public Toggle tomatoTrashToggle;

    public Toggle chickenLegCatToggle;
    public Toggle chickenLegChickToggle;
    public Toggle chickenLegTrashToggle;

    public Toggle cokeCatToggle;
    public Toggle cokeChickToggle;
    public Toggle cokeTrashToggle;

    public Toggle cornCatToggle;
    public Toggle cornChickToggle;
    public Toggle cornTrashToggle;

    void Start()
    {

    }

    //cat best = 1
    //chick best = 3


    // Update is called once per frame
    void Update()
    {

    }

    public void Done()
    {
        //waterMelon
        if (waterMelonCatToggle.isOn)
        {
            Food2Progress.catFood2 = Food2Progress.catFood2 - 1.0f;

        }

        if (waterMelonChickToggle.isOn)
        {
            Food2Progress.chickenFood2 = Food2Progress.chickenFood2 + 1.0f;
        }

        if (waterMelonTrashToggle.isOn)
        {

        }


        //tomato
        if (tomatoCatToggle.isOn)
        {
            Food2Progress.catFood2 = Food2Progress.catFood2 - 1.0f;
        }

        if (tomatoChickToggle.isOn)
        {
            Food2Progress.chickenFood2 = Food2Progress.chickenFood2 + 1.0f;
        }

        if (tomatoTrashToggle.isOn)
        {

        }


        //chickenLeg
        if (chickenLegCatToggle.isOn)
        {
            Food2Progress.catFood2 = Food2Progress.catFood2 + 1.0f;
        }

        if (chickenLegChickToggle.isOn)
        {
            Food2Progress.chickenFood2 = Food2Progress.chickenFood2 - 1.0f;
        }

        if (chickenLegTrashToggle.isOn)
        {

        }


        //coke
        if (cokeCatToggle.isOn)
        {
            Food2Progress.catFood2 = Food2Progress.catFood2 - 1.0f;
        }

        if (cokeChickToggle.isOn)
        {
            Food2Progress.chickenFood2 = Food2Progress.chickenFood2 - 1.0f;
        }

        if (cokeTrashToggle.isOn)
        {

        }

        //corn
        if (cornCatToggle.isOn)
        {
            Food2Progress.catFood2 = Food2Progress.catFood2 - 1.0f;
        }

        if (cornChickToggle.isOn)
        {
            Food2Progress.chickenFood2 = Food2Progress.chickenFood2 + 1.0f;
        }

        if (cornTrashToggle.isOn)
        {

        }

        MatchWordToggle.finalDone = true;
        SceneManager.LoadScene("Progress");
        //ParcentageControl.foodDone = true;
    }
}