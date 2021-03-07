using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectedWords : MonoBehaviour
{
    public Text word1Text;
    public Text word2Text;
    public Text word3Text;
    public Text word4Text;

    public static string word1type;
    public static string word2type;
    public static string word3type;
    public static string word4type;

    // Start is called before the first frame update
    void Start()
    {
        word1Text.text = InputWord1.word1;
        word2Text.text = InputWord2.word2;
        word3Text.text = InputWord3.word3;
        word4Text.text = InputWord4.word4;
    }

    // Update is called once per frame
    void Update()
    {
        if (word1Text.text == "care" || word1Text.text == "feed" || word1Text.text == "love" || word1Text.text == "dear" || word1Text.text == "act" || word1Text.text == "fact" || word1Text.text == "vet" || word1Text.text == "face")
        {
            word1type = "both";
        }
        else if(word1Text.text == "cat")
        {
            word1type = "cat";
        }
        else
        {
            word1type = "none";
        }


        if (word2Text.text == "care" || word2Text.text == "feed" || word2Text.text == "love" || word2Text.text == "dear" || word2Text.text == "act" || word2Text.text == "fact" || word2Text.text == "vet" || word2Text.text == "face")
        {
            word2type = "both";
        }
        else if (word2Text.text == "cat")
        {
            word2type = "cat";
        }
        else
        {
            word2type = "none";
        }


        if (word3Text.text == "care" || word3Text.text == "feed" || word3Text.text == "love" || word3Text.text == "dear" || word3Text.text == "act" || word3Text.text == "fact" || word3Text.text == "vet" || word3Text.text == "face")
        {
            word3type = "both";
        }
        else if (word3Text.text == "cat")
        {
            word3type = "cat";
        }
        else
        {
            word3type = "none";
        }


        if (word4Text.text == "care" || word4Text.text == "feed" || word4Text.text == "love" || word4Text.text == "dear" || word4Text.text == "act" || word4Text.text == "fact" || word4Text.text == "vet" || word4Text.text == "face")
        {
            word4type = "both";
        }
        else if (word4Text.text == "cat")
        {
            word4type = "cat";
        }
        else
        {
            word4type = "none";
        }
    }
}
