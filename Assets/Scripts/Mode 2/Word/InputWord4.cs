using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputWord4 : MonoBehaviour
{
    public InputField inputField4;
    public static string word4 = "";
    // Start is called before the first frame update
    void Start()
    {
        inputField4.characterLimit = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeLower()
    {
        inputField4.text = inputField4.text.ToLower();
        word4 = inputField4.text;
    }


    public void CheckWord()
    {
        for (int i = 0; i < word4.Length; i++)
        {
            if (word4[i] == 'a' || word4[i] == 'c' || word4[i] == 'd' || word4[i] == 'e' || word4[i] == 'f' || word4[i] == 'l' || word4[i] == 'o' || word4[i] == 'r' || word4[i] == 't' || word4[i] == 'v')
            {

            }
            else
            {
                inputField4.text = "";
                word4 = inputField4.text;
            }
        }
    }
}
