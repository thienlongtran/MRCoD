using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenActiveInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void walk()
    {
        SceneManager.LoadScene("ChickenWalk");
    }

    public void item()
    {
        SceneManager.LoadScene("ChickenItem");
    }
}
