using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdownGameController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI resultText;
    [SerializeField] TextMeshProUGUI tryText;
    [SerializeField] Button startButton;
    [SerializeField] Button checkButton;
    [SerializeField] TMP_InputField inputValue;
    int tryCount = 0;
    [SerializeField] int settingNum = 0;

    private void Awake()
    {
        tryCount = 0;
        settingNum = 0;
        checkButton.onClick.AddListener(CheckResult);
        checkButton.interactable = false;
        startButton.onClick.AddListener(InitGame);
        tryText.text = $"�õ��� Ƚ�� : {tryCount}";
    }

    public void CheckResult()
    {
        string resultLog = string.Empty;
        int checkValue = int.Parse(inputValue.text);
        tryCount++;
        tryText.text = $"�õ��� Ƚ�� : {tryCount}";
        if (checkValue > settingNum)
        {
            //�ٿ�
            resultLog = $"\n�Է��� �� : {checkValue} / �ٿ�!";
            resultText.text = resultText.text + resultLog;
        }
        else if(checkValue < settingNum)
        {
            //��
            resultLog = $"\n�Է��� �� : {checkValue} / ��!";
            resultText.text = resultText.text + resultLog;
        }
        else
        {
            //Ŭ����.
            resultLog = $"\n�Է��� �� : {checkValue} / ����!";
            resultText.text = resultText.text + resultLog;
            checkButton.interactable = false;
            startButton.gameObject.SetActive(true);
        }

    }

    public void InitGame()
    {
        settingNum = Random.Range(0, 101);
        checkButton.interactable = true;
        startButton.gameObject.SetActive(false);
        resultText.text = "";
        tryCount = 0;
        tryText.text = $"�õ��� Ƚ�� : {tryCount}";
    }
}
