using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Preference2 : MonoBehaviour
{
    public Toggle try60Toggle;
    public Toggle try5Toggle;
    public Toggle findItemToggle;

    public static string preference2;

    public static int preference2Count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (try60Toggle.isOn)
        {
            preference2 = "Try again using 60 seconds";
        }
        else if (try5Toggle.isOn)
        {
            preference2 = "Try again using 5 Minutes";
        }
        else if (findItemToggle.isOn)
        {
            preference2 = "Find items";
        }
    }

    public void play()
    {
        preference2Count++;
        
        FirebaseInit.reference.Child("Players").Child(GetID.id).Child("Preference2Response "+preference2Count).SetValueAsync(preference2);

        if (try60Toggle.isOn)
        {
            LetterTimer.letterTime = 60;
            SceneManager.LoadScene("LetterCollectScene");
        }
        else if (try5Toggle.isOn)
        {
            LetterTimer.letterTime = 300;
            SceneManager.LoadScene("LetterCollectScene");
        }
        else if (findItemToggle.isOn)
        {
            SceneManager.LoadScene("Foo2Init");
        }
    }
}
