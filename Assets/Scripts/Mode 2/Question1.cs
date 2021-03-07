using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Question1 : MonoBehaviour
{
    public Toggle impossibleToggle;
    public Toggle changeToggle;

    public static bool question1_it_seems_impossible_to_me;
    public static bool question1_I_Dont_like_changes;

    public static string question1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void next()
    {
        if (impossibleToggle.isOn)
        {
            question1 = "It seems impossible to me";
        }
        
        if (changeToggle.isOn)
        {
            question1 = "I do not like changes";
        }
        

        
        FirebaseInit.reference.Child("Players").Child(GetID.id).Child("Question1Response").SetValueAsync(question1);
        SceneManager.LoadScene("Preference1");
    }
}
