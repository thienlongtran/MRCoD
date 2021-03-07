using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Text.RegularExpressions;

public class InputWord3 : MonoBehaviour
{
    public InputField inputField3;
    public static string word3 = "";
    // Start is called before the first frame update
    void Start()
    {
        inputField3.characterLimit = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeLower()
    {
        inputField3.text = inputField3.text.ToLower();
        word3 = inputField3.text;
    }

    public void CheckWord()
    {
        for(int i=0;i<word3.Length;i++)
        {
            if(word3[i]=='a' || word3[i] == 'c' || word3[i] == 'd' || word3[i] == 'e' || word3[i] == 'f' || word3[i] == 'l' || word3[i] == 'o' || word3[i] == 'r' || word3[i] == 't' || word3[i] == 'v')
            {

            }
            else
            {
                inputField3.text = "";
                word3 = inputField3.text;
            }
        }
    }
}
