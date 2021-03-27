using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickButtonMR : MonoBehaviour
{

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
            GetComponent<Button>().onClick.Invoke();
            Debug.Log("Fire 1 Pressed");
        }
    }
}
