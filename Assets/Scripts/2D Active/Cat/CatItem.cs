using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatItem : MonoBehaviour
{
    public static string catItemResult;
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
        catItemResult = "Oops! Wrong Item";
        SceneManager.LoadScene("CatResult");
        BarValue.catActive--;
    }

    public void toy()
    {
        catItemResult = "Perfect";
        SceneManager.LoadScene("CatResult");
        BarValue.catActive++;
    }

    public void knife()
    {
        catItemResult = "Oops! Wrong Item";
        SceneManager.LoadScene("CatResult");
        BarValue.catActive--;
    }

    public void straw()
    {
        catItemResult = "Oops! Wrong Item";
        SceneManager.LoadScene("CatResult");
        BarValue.catActive--;
    }
}
