using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedShelter : MonoBehaviour
{
    public GameObject chickCoop;
    public GameObject basket;
    public GameObject house;
    public GameObject cloth;
    public GameObject cage;

    // Start is called before the first frame update
    void Start()
    {
        chickCoop.SetActive(false);
        basket.SetActive(false);
        house.SetActive(false);
        cloth.SetActive(false);
        cage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ShelterPlacementController.chickCoopIsCollected)
        {
            chickCoop.SetActive(true);
        }

        if (ShelterPlacementController.basketIsCollected)
        {
            basket.SetActive(true);
        }

        if (ShelterPlacementController.houseIsCollected)
        {
            house.SetActive(true);
        }

        if (ShelterPlacementController.clothIsCollected)
        {
            cloth.SetActive(true);
        }

        if (ShelterPlacementController.cageIsCollected)
        {
            cage.SetActive(true);
        }
    }
}
