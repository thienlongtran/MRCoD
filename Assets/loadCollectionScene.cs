using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadCollectionScene : MonoBehaviour
{
    [SerializeField]
    private bool hasHealthPotion = true;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("ItemCollectScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
