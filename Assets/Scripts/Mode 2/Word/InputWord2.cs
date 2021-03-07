using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputWord2 : MonoBehaviour
{
    public InputField inputField2;
    public static string word2 = "";
    // Start is called before the first frame update
    void Start()
    {
        inputField2.characterLimit = 4;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MakeLower()
    {
        inputField2.text = inputField2.text.ToLower();
        word2 = inputField2.text;
    }

    public void CheckWord()
    {
        for (int i = 0; i < word2.Length; i++)
        {
            if (word2[i] == 'a' || word2[i] == 'c' || word2[i] == 'd' || word2[i] == 'e' || word2[i] == 'f' || word2[i] == 'l' || word2[i] == 'o' || word2[i] == 'r' || word2[i] == 't' || word2[i] == 'v')
            {

            }
            else
            {
                inputField2.text = "";
                word2 = inputField2.text;
            }
        }
    }

}
