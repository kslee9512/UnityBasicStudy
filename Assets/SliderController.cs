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
        Debug.Log($"������ : {randomNum} ����!");
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
        Debug.Log($"ȸ�� : {randomNum} ȸ��!");
        UpdateUI();
    }

    public void UpdateUI()
    {
        float healthPercent = (float)curHp / maxHp; //���� ü�� %�� ���
        filledImage.fillAmount = healthPercent; // ����� ���� �̹��� UI�� ����
        uiSlider.value = healthPercent; // ����� ���� �̹��� UI�� ����
        sliderText.text = $"{curHp} / {maxHp}"; // ü�� ���� UI ����
        filledText.text = $"{curHp} / {maxHp}"; // ü�� ���� UI ����
    }
}
