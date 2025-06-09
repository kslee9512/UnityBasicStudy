using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] Image filledImage;
    [SerializeField] Slider uiSlider;
    [SerializeField] TextMeshProUGUI filledText;
    [SerializeField] TextMeshProUGUI sliderText;
    int maxHp = 100;
    int curHp = 0;

    private void Awake()
    {
        curHp = maxHp;
        UpdateUI();
    }

    public void GetDamage()
    {
        int randomNum = Random.Range(0, 101);
        curHp -= randomNum;
        if(curHp < 0)
        {
            curHp = 0;
        }
        Debug.Log($"데미지 : {randomNum} 받음!");
        UpdateUI();
    }

    public void Heal()
    {
        int randomNum = Random.Range(0, 101);
        curHp += randomNum;
        if (curHp > maxHp)
        {
            curHp = maxHp;
        }
        Debug.Log($"회복 : {randomNum} 회복!");
        UpdateUI();
    }

    public void UpdateUI()
    {
        float healthPercent = (float)curHp / maxHp; //현재 체력 %로 계산
        filledImage.fillAmount = healthPercent; // 계산한 값을 이미지 UI에 전달
        uiSlider.value = healthPercent; // 계산한 값을 이미지 UI에 전달
        sliderText.text = $"{curHp} / {maxHp}"; // 체력 숫자 UI 갱신
        filledText.text = $"{curHp} / {maxHp}"; // 체력 숫자 UI 갱신
    }
}
