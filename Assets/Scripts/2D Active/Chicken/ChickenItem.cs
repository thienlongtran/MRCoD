using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenItem : MonoBehaviour
{
    public static string chickenItemResult;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void car()
    {
        chickenItemResult = "Oops! Wrong Item";
        SceneManager.LoadScene("ChickenResult");
        BarValue.chickenActive--;
    }

    public void toy()
    {
        chickenItemResult = "Oops! Wrong Item";
        SceneManager.LoadScene("ChickenResult");
        BarValue.chickenActive--;
    }

    public void knife()
    {
        chickenItemResult = "Oops! Wrong Item";
        SceneManager.LoadScene("ChickenResult");
        BarValue.chickenActive--;
    }

    public void straw()
    {
        chickenItemResult = "Perfect";
        SceneManager.LoadScene("ChickenResult");
        BarValue.chickenActive++;
    }
}
