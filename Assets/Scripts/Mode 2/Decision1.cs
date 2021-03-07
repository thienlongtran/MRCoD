using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Decision1 : MonoBehaviour
{
    public Toggle tryToggle;
    public Toggle failToggle;
    public Toggle noWayToggle;

    public static string decision1;

    public static int decision1Count=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tryToggle.isOn)
        {
            decision1 = "I want to try again";
        }
        else if (failToggle.isOn)
        {
            decision1 = "I think I will fail again";
        }
        else if (noWayToggle.isOn)
        {
            decision1 = "There is no way to solve it in time";
        }
    }

    public void nextButton()
    {
        decision1Count++;
        FirebaseInit.reference.Child("Players").Child(GetID.id).Child("Decision1Response " + decision1Count).SetValueAsync(decision1);

        if (tryToggle.isOn)
        {
            SceneManager.LoadScene("Preference2");
        }
        else if(failToggle.isOn || noWayToggle.isOn)
        {
            SceneManager.LoadScene("Question2");
        }
        
    }
}
