using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Firebase;
using Firebase.Database;

public class FirebaseInit : MonoBehaviour
{
    public static FirebaseApp firebaseApp;
    public static bool firebaseReadyToUse = false;
    public static DatabaseReference reference;

    // Start is called before the first frame update
    void Start()
    {
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                Debug.Log("Enter Firebase");
                // canvas2.SetActive(false);
                // Create and hold a reference to your FirebaseApp,
                // where app is a Firebase.FirebaseApp property of your application class.
                firebaseApp = Firebase.FirebaseApp.DefaultInstance;
                firebaseReadyToUse = true;
                reference = FirebaseDatabase.DefaultInstance.RootReference;

                PlayerDatabase playerDatabase = new PlayerDatabase(YesNoButton.yesNo, Question1.question1,
                    Preference1.preference1, Preference2.preference2,Decision1.decision1, Question2.question2,
                    BarValue.catHealth, BarValue.catActive, BarValue.chickenHealth, BarValue.chickenActive);

                // Set a flag here to indicate whether Firebase is ready to use by your app.
            }
            else
            {
                Debug.Log(" not Enter Firebase");
                UnityEngine.Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
                // Firebase Unity SDK is not safe to use here.
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
