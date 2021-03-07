using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoodResult : MonoBehaviour
{
    [SerializeField]
    Text foodResult;

    [SerializeField]
    Button nextButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foodResult.text = Mathf.Round(FoodProgress.catFoodTotal).ToString() + "% cat foods are perfectly matched\n\n"+Mathf.Round(FoodProgress.chickenFoodTotal).ToString()+
            "% chicken foods are perfectly matched";
    }

    public void Next()
    {
        if(PlayOrder2.playOrderDone2==true)
        {
            if(PlayOrder.shelterDone==false)
            {
                SceneManager.LoadScene("ShelterInit");
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
