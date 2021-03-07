using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedItems : MonoBehaviour
{
    public GameObject wool;
    public GameObject knife;
    public GameObject egg;
    public GameObject leg;
    public GameObject toy;
    // Start is called before the first frame update
    void Start()
    {
        
        wool.SetActive(false);
        knife.SetActive(false);
        egg.SetActive(false);
        leg.SetActive(false);
        toy.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemPlacementController.woolIsCollected)
        {
            wool.SetActive(true);
        }

        if (ItemPlacementController.knifeIsCollected)
        {
            knife.SetActive(true);
        }

        if (ItemPlacementController.eggIsCollected)
        {
            egg.SetActive(true);
        }

        if (ItemPlacementController.legIsCollected)
        {
            leg.SetActive(true);
        }

        if (ItemPlacementController.toyIsCollected)
        {
            toy.SetActive(true);
        }
    }
}
