using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayOrder : MonoBehaviour
{
    [SerializeField]
    Button shelterButton;

    [SerializeField]
    Button foodButton;

    [SerializeField]
    Button itemButton;


    public static bool startWithFood;


    public static bool shelterDone;
    public static bool foodDone;
    public static bool itemDone;

    // Start is called before the first frame update
    void Start()
    {
        startWithFood = false;


        shelterDone = false;
        foodDone = false;
        itemDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shelter()
    {
        shelterDone = true;
        SceneManager.LoadScene("ShelterInit");
    }

    public void food()
    {
        foodDone = true;

        startWithFood = true;
        SceneManager.LoadScene("FoodInit");
    }

    public void item()
    {
        itemDone = true;
        SceneManager.LoadScene("ItemInit");
    }
}
