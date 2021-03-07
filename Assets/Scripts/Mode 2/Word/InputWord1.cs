using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputWord1 : MonoBehaviour
{
    public InputField inputField1;
    public static string word1 = "";
    // Start is called before the first frame update
    void Start()
    {
        inputField1.characterLimit = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeLower()
    {
        inputField1.text = inputField1.text.ToLower();
        word1 = inputField1.text;
    }

    public void CheckWord()
    {
        for (int i = 0; i < word1.Length; i++)
        {
            if (word1[i] == 'a' || word1[i] == 'c' || word1[i] == 'd' || word1[i] == 'e' || word1[i] == 'f' || word1[i] == 'l' || word1[i] == 'o' || word1[i] == 'r' || word1[i] == 't' || word1[i] == 'v')
            {

            }
            else
            {
                inputField1.text = "";
                word1 = inputField1.text;
            }
        }
    }
}
