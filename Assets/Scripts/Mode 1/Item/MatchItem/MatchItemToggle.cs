using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchItemToggle : MonoBehaviour
{
    public Toggle woolCatToggle;
    public Toggle woolChickToggle;
    public Toggle woolTrashToggle;

    public Toggle knifeCatToggle;
    public Toggle knifeChickToggle;
    public Toggle knifeTrashToggle;

    public Toggle eggCatToggle;
    public Toggle eggChickToggle;
    public Toggle eggTrashToggle;

    public Toggle legCatToggle;
    public Toggle legChickToggle;
    public Toggle legTrashToggle;

    public Toggle toyCatToggle;
    public Toggle toyChickToggle;
    public Toggle toyTrashToggle;

    // Start is called before the first frame update
    void Start()
    {

    }

    //cat best = 3
    //chick best = 1


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Done()
    {
        //wool
        if (woolCatToggle.isOn)
        {
            ItemProgress.catItem = ItemProgress.catItem + 1.0f;
        }

        if (woolChickToggle.isOn)
        {
            ItemProgress.chickenItem = ItemProgress.chickenItem - 1.0f;
        }

        if (woolTrashToggle.isOn)
        {

        }


        //knife
        if (knifeCatToggle.isOn)
        {
            ItemProgress.catItem = ItemProgress.catItem - 1.0f;
        }

        if (knifeChickToggle.isOn)
        {
            ItemProgress.chickenItem = ItemProgress.chickenItem - 1.0f;
        }

        if (knifeTrashToggle.isOn)
        {

        }


        //egg
        if (eggCatToggle.isOn)
        {
            ItemProgress.catItem = ItemProgress.catItem - 1.0f;
        }

        if (eggChickToggle.isOn)
        {
            ItemProgress.chickenItem = ItemProgress.chickenItem + 1.0f;
        }

        if (eggTrashToggle.isOn)
        {

        }



        //leg
        if (legCatToggle.isOn)
        {
            ItemProgress.catItem = ItemProgress.catItem + 1.0f;
        }

        if (legChickToggle.isOn)
        {
            ItemProgress.chickenItem = ItemProgress.chickenItem - 1.0f;
        }

        if (legTrashToggle.isOn)
        {

        }


        //toy
        if (toyCatToggle.isOn)
        {
            ItemProgress.catItem = ItemProgress.catItem + 1.0f;
        }

        if (toyChickToggle.isOn)
        {
            ItemProgress.chickenItem = ItemProgress.chickenItem - 1.0f;
        }

        if (toyTrashToggle.isOn)
        {

        }

        SceneManager.LoadScene("ItemResult");
    }
}
