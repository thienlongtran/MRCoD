using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AvtiveInit : MonoBehaviour
{
    public static bool activeIsPlayed;
    // Start is called before the first frame update
    void Start()
    {
        activeIsPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void yes()
    {
        SceneManager.LoadScene("CatActiveInit");
        activeIsPlayed = true;
    }

    public void no()
    {
        if(YesNoButton.yesNo=="yes")
        {
            SceneManager.LoadScene("LetterCollectScene");
        }

        else if (YesNoButton.yesNo == "no")
        {
            if(Preference1.preference1== "Play using 5 Minutes")
            {
                LetterTimer.letterTime = 300;
                SceneManager.LoadScene("LetterCollectScene");
            }
            else if(Preference1.preference1 == "Find items")
            {
                SceneManager.LoadScene("Foo2Init");
            }
        }
    }
}
