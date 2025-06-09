using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData
{
    public string charName;
    public string charImg;
    public int charGrade;

    public void InitData(string CharName, string CharImg, int CharGrade)
    {
        charName = CharName;
        charImg = CharImg;
        charGrade = CharGrade;
    }
}
