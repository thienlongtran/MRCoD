using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemResult : MonoBehaviour
{
    [SerializeField]
    Text itemResult;

    [SerializeField]
    Button nextButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        itemResult.text = Mathf.Round(ItemProgress.catItemTotal).ToString() + "% cat items are perfectly matched\n\n" + Mathf.Round(ItemProgress.chickenItemTotal).ToString() +
            "% chicken items are perfectly matched";
    }

    public void Next()
    {
        if (PlayOrder2.playOrderDone2 == true)
        {
            if (PlayOrder.shelterDone == false)
            {
                SceneManager.LoadScene("ShelterInit");
            }
            else if (PlayOrder.foodDone == false)
            {
                SceneManager.LoadScene("FoodInit");
            }
            else
            {
                SceneManager.LoadScene("Progress");
            }
        }
        else
        {
            SceneManager.LoadScene("OrderOfPlay2");
        }
    }
}
