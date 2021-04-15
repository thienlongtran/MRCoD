using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

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
            StartCoroutine(SwitchTo2D());
            SceneManager.LoadScene("LetterMiddlemanScene");
        }

        else if (YesNoButton.yesNo == "no")
        {
            if(Preference1.preference1== "Play using 5 Minutes")
            {
                LetterTimer.letterTime = 300;
                StartCoroutine(SwitchTo2D());
                SceneManager.LoadScene("LetterMiddlemanScene");
            }
            else if(Preference1.preference1 == "Find items")
            {
                SceneManager.LoadScene("Foo2Init");
            }
        }
    }

    // Call via `StartCoroutine(SwitchTo2D())` from your code. Or, use
    // `yield SwitchTo2D()` if calling from inside another coroutine.
    IEnumerator SwitchTo2D()
    {
        // Empty string loads the "None" device.
        XRSettings.LoadDeviceByName("");

        // Must wait one frame after calling `XRSettings.LoadDeviceByName()`.
        yield return null;

        // Not needed, since loading the None (`""`) device takes care of this.
        // XRSettings.enabled = false;

        // Restore 2D camera settings.
        ResetCameras();
    }

    // Resets camera transform and settings on all enabled eye cameras.
    void ResetCameras()
    {
        // Camera looping logic copied from GvrEditorEmulator.cs
        for (int i = 0; i < Camera.allCameras.Length; i++)
        {
            Camera cam = Camera.allCameras[i];
            if (cam.enabled && cam.stereoTargetEye != StereoTargetEyeMask.None)
            {

                // Reset local position.
                // Only required if you change the camera's local position while in 2D mode.
                cam.transform.localPosition = Vector3.zero;

                // Reset local rotation.
                // Only required if you change the camera's local rotation while in 2D mode.
                cam.transform.localRotation = Quaternion.identity;

                // No longer needed, see issue github.com/googlevr/gvr-unity-sdk/issues/628.
                // cam.ResetAspect();

                // No need to reset `fieldOfView`, since it's reset automatically.
            }
        }
    }
}
