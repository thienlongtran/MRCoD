using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColCat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="cat")
        {
            CatItem.catItemResult = "Perfect";
            BarValue.catActive++;
            SceneManager.LoadScene("CatResult");
        }
    }
}
