using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class WordsAndButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoneButton()
    {
        if(InputWord1.word1.Length!=0 && InputWord2.word2.Length != 0 && InputWord3.word3.Length != 0 && InputWord4.word4.Length != 0)
        {
            SceneManager.LoadScene("MatchWord");
            
        }
        else
        {
            SceneManager.LoadScene("Decision1");
        }
    }
}
