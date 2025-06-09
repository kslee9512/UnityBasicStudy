using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaResultSlot : MonoBehaviour
{
    [SerializeField] Image characterImage;
    [SerializeField] Image gradeImage;
    [SerializeField] GameObject[] gradeStarObj;
    public void InitSlotData(CharacterData CharData)
    {
        string imagePath = string.Empty;
        Color newColor;
        switch (CharData.charGrade)
        {
            case 1:
                gradeStarObj[0].SetActive(true);
                gradeStarObj[1].SetActive(false);
                gradeStarObj[2].SetActive(false);
                imagePath = "GachaImg/1Tier/" + CharData.charImg;
                characterImage.sprite = Resources.Load<Sprite>(imagePath);
                gradeImage.color = Color.gray;
                break;
            case 2:
                gradeStarObj[0].SetActive(false);
                gradeStarObj[1].SetActive(true);
                gradeStarObj[2].SetActive(false);
                imagePath = "GachaImg/2Tier/" + CharData.charImg;
                characterImage.sprite = Resources.Load<Sprite>(imagePath);
                gradeImage.color = new Color(1.0f, 0.9686275f, 0.5294118f);
                    break;
            case 3:
                gradeStarObj[0].SetActive(false);
                gradeStarObj[1].SetActive(false);
                gradeStarObj[2].SetActive(true);
                imagePath = "GachaImg/3Tier/" + CharData.charImg;
                characterImage.sprite = Resources.Load<Sprite>(imagePath);
                if (ColorUtility.TryParseHtmlString("F7C2DC", out newColor)) gradeImage.color = newColor;
                else gradeImage.color = new Color(0.9686275f, 0.7607844f, 0.8627452f);
                break;
        }
    }

    public void InitPos(Vector2 posVal)
    {
        var obj = this.gameObject.GetComponent<RectTransform>();
        obj.anchoredPosition = new Vector2(posVal.x, posVal.y);
    }
}
