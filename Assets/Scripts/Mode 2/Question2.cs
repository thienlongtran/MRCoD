using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Question2 : MonoBehaviour
{
    public Toggle impossibleToggle;
    public Toggle changeToggle;

    public static bool question2_it_seems_impossible_to_me;
    public static bool question2_I_Dont_like_changes;

    public static string question2;

    public static int question2Count = 0;

    // Start is called before the first frame update
    void Start()
    {
        question2_it_seems_impossible_to_me = false;
        question2_I_Dont_like_changes = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void next()
    {
        if (impossibleToggle.isOn)
        {
            question2 = "It seems impossible to me";
        }

        if (changeToggle.isOn)
        {
            question2 = "I do not like changes";
        }
        

        question2Count++;

        FirebaseInit.reference.Child("Players").Child(GetID.id).Child("Question2Response " + question2Count).SetValueAsync(question2);
        SceneManager.LoadScene("Preference2");
    }
}
