using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickButtonMR : MonoBehaviour
{

    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Click button when user "clicks" using the side lever
        if (Input.GetButtonUp("Fire1"))
        {
            button.onClick.Invoke();
            Debug.Log("Fire 1 Pressed");
        }
    }
}
