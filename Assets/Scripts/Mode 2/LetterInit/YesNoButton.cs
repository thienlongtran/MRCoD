using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YesNoButton : MonoBehaviour
{
    public static string yesNo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void yes()
    {
        yesNo = "yes";
        // PlayerDatabase playerDatabase = new PlayerDatabase(yesNo);
        //string json = JsonUtility.ToJson(playerDatabase);

        
        FirebaseInit.reference.Child("Players").Child(GetID.id).Child("LetterInitPlayIn60").SetValueAsync(yesNo);
        LetterTimer.letterTime = 30;

        //SceneManager.LoadScene("LetterCollectScene");
        SceneManager.LoadScene("ActiveInit");
    }

    public void no()
    {
        yesNo = "no";
        //PlayerDatabase playerDatabase = new PlayerDatabase(yesNo);
       // string json = JsonUtility.ToJson(playerDatabase);

  
        FirebaseInit.reference.Child("Players").Child(GetID.id).Child("LetterInitPlayIn60").SetValueAsync(yesNo);

        SceneManager.LoadScene("Question1");
    }
}
