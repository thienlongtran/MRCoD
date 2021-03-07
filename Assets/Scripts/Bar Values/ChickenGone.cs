using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenGone : MonoBehaviour
{
    [SerializeField]
    GameObject chickenBars;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ChickenWalk.chickWalk==true)
        {
            chickenBars.SetActive(false);
        }
    }
}
