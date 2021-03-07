using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDatabase
{
    public string LetterInitPlayIn60;

    

    public string Question1Respone;

    public string Preference1Response;

    public string Decision1Response;

    public string Preference2Response;

    public string Question2Respone;

    public int catHealth;

    public int catActive;

    public int chickenHealth;

    public int chickenActive;


    public PlayerDatabase()
    {

    }

    public PlayerDatabase(string LetterInitPlayIn60,
        string question1,
        string preference1,
        string preference2,
        string decision1,
        string question2,
        int catHealth,
        int catActive,
        int chickenHealth,
        int chickenActive)
    {
        this.LetterInitPlayIn60 = LetterInitPlayIn60;
        Question1Respone = question1;
        Preference1Response = preference1;
        Preference2Response = preference2;
        Decision1Response = decision1;
        Question2Respone = question2;
        this.catHealth = catHealth;
        this.catActive = catActive;
        this.chickenHealth = chickenHealth;
        this.chickenActive = chickenActive;

    }
}
