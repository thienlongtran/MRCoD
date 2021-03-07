using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveBar : MonoBehaviour
{
    [SerializeField]
    Image[] catActiveBar;

    [SerializeField]
    Image[] chickenActiveBar;

    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < BarValue.catActive; i++)
        {
            catActiveBar[i].GetComponent<Image>().color = UnityEngine.Color.white;
        }

        for (int i = 0; i < BarValue.chickenActive; i++)
        {
            chickenActiveBar[i].GetComponent<Image>().color = UnityEngine.Color.white;
        }
    }

}
