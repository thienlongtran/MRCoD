using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChickenResult : MonoBehaviour
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
        result.text = ChickenItem.chickenItemResult;
    }

    public void next()
    {
        SceneManager.LoadScene("Progress");
    }
}
