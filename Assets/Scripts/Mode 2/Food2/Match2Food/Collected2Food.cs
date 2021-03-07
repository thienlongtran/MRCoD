using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collected2Food : MonoBehaviour
{
    public GameObject waterMelon;
    public GameObject tomato;
    public GameObject chickenLeg;
    public GameObject coke;
    public GameObject corn;
    // Start is called before the first frame update
    void Start()
    {

        /*waterMelon.SetActive(false);
        tomato.SetActive(false);
        chickenLeg.SetActive(false);
        coke.SetActive(false);
        corn.SetActive(false);*/

    }

    // Update is called once per frame
    void Update()
    {
        if (Food2PlacementController.waterMelonIsCollected)
        {
            waterMelon.SetActive(true);
        }

        if (Food2PlacementController.tomatoIsCollected)
        {
            tomato.SetActive(true);
        }

        if (Food2PlacementController.chickenLegIsCollected)
        {
            chickenLeg.SetActive(true);
        }

        if (Food2PlacementController.cokeIsCollected)
        {
            coke.SetActive(true);
        }

        if (Food2PlacementController.cornIsCollected)
        {
            corn.SetActive(true);
        }
    }
}
