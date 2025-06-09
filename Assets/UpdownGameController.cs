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
        tryText.text = $"시도한 횟수 : {tryCount}";
    }

    public void CheckResult()
    {
        string resultLog = string.Empty;
        int checkValue = int.Parse(inputValue.text);
        tryCount++;
        tryText.text = $"시도한 횟수 : {tryCount}";
        if (checkValue > settingNum)
        {
            //다운
            resultLog = $"\n입력한 값 : {checkValue} / 다운!";
            resultText.text = resultText.text + resultLog;
        }
        else if(checkValue < settingNum)
        {
            //업
            resultLog = $"\n입력한 값 : {checkValue} / 업!";
            resultText.text = resultText.text + resultLog;
        }
        else
        {
            //클리어.
            resultLog = $"\n입력한 값 : {checkValue} / 정답!";
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
        tryText.text = $"시도한 횟수 : {tryCount}";
    }
}
