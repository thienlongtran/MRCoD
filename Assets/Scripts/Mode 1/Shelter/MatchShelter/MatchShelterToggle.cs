using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchShelterToggle : MonoBehaviour
{
    public Toggle chickenCoopCatToggle;
    public Toggle chickenCoopChickToggle;
    public Toggle chickenCoopTrashToggle;

    public Toggle basketCatToggle;
    public Toggle basketChickToggle;
    public Toggle basketTrashToggle;

    public Toggle houseCatToggle;
    public Toggle houseChickToggle;
    public Toggle houseTrashToggle;

    public Toggle clothBucketCatToggle;
    public Toggle clothBucketChickToggle;
    public Toggle clothBucketTrashToggle;

    public Toggle cageCatToggle;
    public Toggle cageChickToggle;
    public Toggle cageTrashToggle;

    // Start is called before the first frame update
    void Start()
    {

    }

    //cat best = 1.9
    //chick best = 1.9

    // Update is called once per frame
    void Update()
    {
        
    }

    public void done()
    {
        //chickenCoop
        if (chickenCoopCatToggle.isOn)
        {
            ShelterProgress.catShelter = ShelterProgress.catShelter - 1.0f;
        }

        if (chickenCoopChickToggle.isOn)
        {
            ShelterProgress.chickenShelter = ShelterProgress.chickenShelter + 1.0f;
        }

        if (chickenCoopTrashToggle.isOn)
        {

        }


        //basket
        if (basketCatToggle.isOn)
        {
            ShelterProgress.catShelter = ShelterProgress.catShelter + 1.0f;
        }

        if (basketChickToggle.isOn)
        {
            ShelterProgress.chickenShelter = ShelterProgress.chickenShelter - 1.0f;
        }

        if (basketTrashToggle.isOn)
        {

        }


        //house
        if (houseCatToggle.isOn)
        {
            ShelterProgress.catShelter = ShelterProgress.catShelter + 0.9f;
        }

        if (houseChickToggle.isOn)
        {
            ShelterProgress.chickenShelter = ShelterProgress.chickenShelter + 0.1f;
        }

        if (houseTrashToggle.isOn)
        {

        }


        //clothBucket
        if (clothBucketCatToggle.isOn)
        {
            ShelterProgress.catShelter = ShelterProgress.catShelter - 1.0f;
        }

        if (clothBucketChickToggle.isOn)
        {
            ShelterProgress.chickenShelter = ShelterProgress.chickenShelter - 1.0f;
        }

        if (clothBucketTrashToggle.isOn)
        {

        }

        //cage
        if (cageCatToggle.isOn)
        {
            ShelterProgress.catShelter = ShelterProgress.catShelter + 0.1f;
        }

        if (cageChickToggle.isOn)
        {
            ShelterProgress.chickenShelter = ShelterProgress.chickenShelter + 0.9f;
        }

        if (cageTrashToggle.isOn)
        {

        }

        SceneManager.LoadScene("ShelterResult");
    }
}
