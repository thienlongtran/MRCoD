using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchWordToggle : MonoBehaviour
{
    public Toggle word1PetToggle;
    public Toggle word1TrashToggle;

    public Toggle word2PetToggle;
    public Toggle word2TrashToggle;

    public Toggle word3PetToggle;
    public Toggle word3TrashToggle;

    public Toggle word4PetToggle;
    public Toggle word4TrashToggle;

    public static bool finalDone;

    // Start is called before the first frame update
    void Start()
    {
        finalDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //cat best = 4
    //chick best = 4

    public void Done()
    {
        if (word1PetToggle.isOn)
        {
            if (CollectedWords.word1type == "both")
            {
                WordProgress.catWords = WordProgress.catWords + 1.0f;
                WordProgress.chickenWords = WordProgress.chickenWords + 1.0f;
            }
            else if (CollectedWords.word1type == "cat")
            {
                WordProgress.catWords = WordProgress.catWords + 1.0f;
            }
            else if (CollectedWords.word1type == "none")
            {
                WordProgress.catWords = WordProgress.catWords - 1.0f;
                WordProgress.chickenWords = WordProgress.chickenWords - 1.0f;
            }
        }

        if (word1TrashToggle.isOn)
        {

        }




        if (word2PetToggle.isOn)
        {
            if (CollectedWords.word2type == "both")
            {
                WordProgress.catWords = WordProgress.catWords + 1.0f;
                WordProgress.chickenWords = WordProgress.chickenWords + 1.0f;
            }
            else if (CollectedWords.word2type == "cat")
            {
                WordProgress.catWords = WordProgress.catWords + 1.0f;
            }
            else if (CollectedWords.word2type == "none")
            {
                WordProgress.catWords = WordProgress.catWords - 1.0f;
                WordProgress.chickenWords = WordProgress.chickenWords - 1.0f;
            }
        }

        if (word2TrashToggle.isOn)
        {

        }




        if (word3PetToggle.isOn)
        {
            if (CollectedWords.word3type == "both")
            {
                WordProgress.catWords = WordProgress.catWords + 1.0f;
                WordProgress.chickenWords = WordProgress.chickenWords + 1.0f;
            }
            else if (CollectedWords.word3type == "cat")
            {
                WordProgress.catWords = WordProgress.catWords + 1.0f;
            }
            else if (CollectedWords.word3type == "none")
            {
                WordProgress.catWords = WordProgress.catWords - 1.0f;
                WordProgress.chickenWords = WordProgress.chickenWords - 1.0f;
            }
        }

        if (word3TrashToggle.isOn)
        {

        }




        if (word4PetToggle.isOn)
        {
            if (CollectedWords.word4type == "both")
            {
                WordProgress.catWords = WordProgress.catWords + 1.0f;
                WordProgress.chickenWords = WordProgress.chickenWords + 1.0f;
            }
            else if (CollectedWords.word4type == "cat")
            {
                WordProgress.catWords = WordProgress.catWords + 1.0f;
            }
            else if (CollectedWords.word4type == "none")
            {
                WordProgress.catWords = WordProgress.catWords - 1.0f;
                WordProgress.chickenWords = WordProgress.chickenWords - 1.0f;
            }
        }

        if (word4TrashToggle.isOn)
        {

        }



        finalDone = true;
        SceneManager.LoadScene("Progress");
    }

}
