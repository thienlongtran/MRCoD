using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedFoods : MonoBehaviour
{
    public GameObject milk;
    public GameObject ant;
    public GameObject grass;
    public GameObject orange;
    public GameObject fish;
    // Start is called before the first frame update
    void Start()
    {
     
        milk.SetActive(false);
        ant.SetActive(false);
        grass.SetActive(false);
        orange.SetActive(false);
        fish.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FoodPlacementController.milkIsCollected)
        {
            milk.SetActive(true);
        }

        if (FoodPlacementController.antIsCollected)
        {
            ant.SetActive(true);
        }

        if (FoodPlacementController.grassIsCollected)
        {
            grass.SetActive(true);
        }

        if (FoodPlacementController.orangeIsCollected)
        {
            orange.SetActive(true);
        }

        if (FoodPlacementController.fishIsCollected)
        {
            fish.SetActive(true);
        }
    }
}
