using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CatResult : MonoBehaviour
{
    [SerializeField]
    Text result;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        result.text = CatItem.catItemResult;
    }

    public void next()
    {
        SceneManager.LoadScene("ChickenActiveInit");
    }
}
