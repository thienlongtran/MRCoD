using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectedLetters : MonoBehaviour
{
    string A;
    string C;
    string D;
    string E;
    string F;
    string L;
    string O;
    string R;
    string T;
    string V;

    Text collectedLetters;
    // Start is called before the first frame update
    void Start()
    {
        collectedLetters = gameObject.GetComponent<Text>();
        A ="";
        C="";
        D="";
        E="";
        F = "";
        L="";
        O="";
        R="";
        T="";
        V="";
    }

    // Update is called once per frame
    void Update()
    {
        if(LetterPlacementController.aIsCollected)
        {
            A="A";
        }

        if (LetterPlacementController.cIsCollected)
        {
            C=", C";
        }

        if (LetterPlacementController.dIsCollected)
        {
            D=", D";
        }

        if (LetterPlacementController.eIsCollected)
        {
            E=", E";
        }

        if (LetterPlacementController.fIsCollected)
        {
            F = ", F";
        }

        if (LetterPlacementController.lIsCollected)
        {
            L=", L";
        }

        if (LetterPlacementController.oIsCollected)
        {
            O=", O";
        }

        if (LetterPlacementController.rIsCollected)
        {
            R=", R";
        }

        if (LetterPlacementController.tIsCollected)
        {
            T=", T"; 
        }

        if (LetterPlacementController.vIsCollected)
        {
            V=", V";
        }

        collectedLetters.text = "You have collected\n" + A + C + D + E + F + L + O + R + T + V;
    }
}
