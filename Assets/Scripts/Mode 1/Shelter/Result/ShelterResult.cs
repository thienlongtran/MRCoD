using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShelterResult : MonoBehaviour
{
    [SerializeField]
    Text shelterResult;

    [SerializeField]
    Button nextButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shelterResult.text = Mathf.Round(ShelterProgress.catShelterTotal).ToString() + "% cat shelters are perfectly matched\n\n" + Mathf.Round(ShelterProgress.chickenShelterTotal).ToString() +
            "% chicken shelters are perfectly matched";
    }

    public void Next()
    {
        if (PlayOrder2.playOrderDone2 == true)
        {
            if (PlayOrder.foodDone == false)
            {
                SceneManager.LoadScene("FoodInit");
            }
            else if (PlayOrder.itemDone == false)
            {
                SceneManager.LoadScene("ItemInit");
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
