using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Preference1 : MonoBehaviour
{
    public Toggle playToggle;
    public Toggle findItemToggle;

    public static string preference1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playToggle.isOn)
        {
            preference1 = "Play using 5 Minutes";
        }
        else if(findItemToggle.isOn)
        {
            preference1 = "Find items";
        }
    }

    public void play()
    {
        FirebaseInit.reference.Child("Players").Child(GetID.id).Child("Preference1Response").SetValueAsync(preference1);


        if (playToggle.isOn)
        {
            LetterTimer.letterTime = 300;
            // SceneManager.LoadScene("LetterCollectScene");
            SceneManager.LoadScene("ActiveInit");
        }
        else if (findItemToggle.isOn)
        {
            //  SceneManager.LoadScene("Foo2Init");
            SceneManager.LoadScene("ActiveInit");
        }
    }
}
