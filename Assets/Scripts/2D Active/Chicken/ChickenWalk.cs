using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenWalk : MonoBehaviour
{
    public static bool chickWalk;

    // Start is called before the first frame update
    void Start()
    {
        chickWalk = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void next()
    {
        chickWalk = true;
        SceneManager.LoadScene("Progress");
    }
}
