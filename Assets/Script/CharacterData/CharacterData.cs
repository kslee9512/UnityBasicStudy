using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData 
{
    //캐릭터 정보 저장을 위한 Class
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
