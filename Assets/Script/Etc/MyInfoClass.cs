using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInfoClass
{
    private int myAge = 31;
    private string myName = "이경식";
    private string myMBTI = "ISTJ";
    private int myHeight = 178;
    private string myBloodType = "B";
    private float eyeSightLeft = 1.0f;
    private float eyeSightRight = 1.0f;
    private string favoriteFood = "피자";
    private string myEducation = "대졸";
    private string favoriteGameGenre = "액션, 서브컬쳐";
    private string myfavoriteColor = "검은색";
    public int GetMyAge() { return myAge; }
    public string GetMyName() { return myName; }
    public string GetMyMBTI() { return myMBTI; }
    public int GetMyHeight() { return myHeight; }
    public string GetMyBloodType() { return myBloodType; }
    public float GetMyeyeSightLeft() { return eyeSightLeft; }
    public float GetMyEyeSightRight() { return eyeSightRight; }
    public string GetMyFavoriteFood() { return favoriteFood; }
    public string GetMyFavoriteGameGenre() { return favoriteGameGenre; }
    public string GetMyFavoriteColor() { return myfavoriteColor; }
    public string GetMyEducation() { return myEducation; }

}
