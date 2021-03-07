using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextButton : MonoBehaviour
{
    [SerializeField]
    Button finishButton;

    [SerializeField]
    GameObject CongratsText;
    // Start is called before the first frame update
    void Start()
    {
        CongratsText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (MatchWordToggle.finalDone == true)
        {
            CongratsText.SetActive(true);
            finishButton.GetComponentInChildren<Text>().text = "Finish Game";
        }
    }

    public void Next()
    {
        if(AvtiveInit.activeIsPlayed==true)
        {
            if (YesNoButton.yesNo == "yes")
            {
                SceneManager.LoadScene("LetterCollectScene");
            }

            else if (YesNoButton.yesNo == "no")
            {
                if (Preference1.preference1 == "Play using 5 Minutes")
                {
                    LetterTimer.letterTime = 300;
                    SceneManager.LoadScene("LetterCollectScene");
                }
                else if (Preference1.preference1 == "Find items")
                {
                    SceneManager.LoadScene("Foo2Init");
                }
            }
            AvtiveInit.activeIsPlayed = false;
        }

        else if(MatchWordToggle.finalDone==true)
        {
            FirebaseInit.reference.Child("Players").Child(GetID.id).Child("CatHealth").SetValueAsync(BarValue.catHealth);
            FirebaseInit.reference.Child("Players").Child(GetID.id).Child("CatActive").SetValueAsync(BarValue.catActive);

            FirebaseInit.reference.Child("Players").Child(GetID.id).Child("ChickenHealth").SetValueAsync(BarValue.chickenHealth);
            FirebaseInit.reference.Child("Players").Child(GetID.id).Child("ChickenActive").SetValueAsync(BarValue.chickenActive);
            Application.Quit();
        }

        else
        {
            SceneManager.LoadScene("LetterInitScene");
        }
        
    }



}
