using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayOrder2 : MonoBehaviour
{
    [SerializeField]
    Button button1;

    [SerializeField]
    Button button2;

    string text1;
    string text2;

    public static bool playOrderDone2;

    // Start is called before the first frame update
    void Start()
    {
        playOrderDone2 = true;

        if (PlayOrder.shelterDone == true)
        {
            text1 = "Food";
            text2 = "Relatable Items";
        }
        else if (PlayOrder.foodDone == true)
        {
            text1 = "Shelter";
            text2 = "Relatable Items";
        }
        else if (PlayOrder.itemDone == true)
        {
            text1 = "Shelter";
            text2 = "Food";
        }

        button1.GetComponentInChildren<Text>().text = text1;
        button2.GetComponentInChildren<Text>().text = text2;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FirstButton()
    {
        if (button1.GetComponentInChildren<Text>().text == "Food")
        {
            PlayOrder.foodDone = true;
            SceneManager.LoadScene("FoodInit");
        }
        else if(button1.GetComponentInChildren<Text>().text == "Shelter")
        {
            PlayOrder.shelterDone = true;
            SceneManager.LoadScene("ShelterInit");
        }
    }

    public void SecondButton()
    {
        if (button2.GetComponentInChildren<Text>().text == "Relatable Items")
        {
            PlayOrder.itemDone = true;
            SceneManager.LoadScene("ItemInit");
        }
        else if (button2.GetComponentInChildren<Text>().text == "Food")
        {
            PlayOrder.foodDone = true;
            SceneManager.LoadScene("FoodInit");
        }
    }
}
