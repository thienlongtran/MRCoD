using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    Image[] catHealthBar;

    [SerializeField]
    Image[] chickenHealthBar;

    //public static int catHealth;
    //public static int chickenHealth;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<BarValue.catHealth;i++)
        {
            catHealthBar[i].GetComponent<Image>().color = UnityEngine.Color.white;
        }

        for (int i = 0; i < BarValue.chickenHealth; i++)
        {
            chickenHealthBar[i].GetComponent<Image>().color = UnityEngine.Color.white;
        }
    }
}
