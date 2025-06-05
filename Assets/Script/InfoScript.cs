using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour
{
    [SerializeField] Button ageButton;
    [SerializeField] Button nameButton;
    [SerializeField] Button heightButton;
    [SerializeField] Button mbtiButton;
    [SerializeField] TextMeshProUGUI textLabel;

    private void Awake()
    {
        ageButton.onClick.AddListener(OnClickAgeButton);
        nameButton.onClick.AddListener(OnClickNameButton);
        heightButton.onClick.AddListener(OnClickHeightButton);
        mbtiButton.onClick.AddListener(OnClickMbtiButton);
        textLabel.text = "무엇이 궁금한가요?";
    }

    public void OnClickAgeButton()
    {
        textLabel.text = $"저의 나이는 {GameManager.Instance.GetMyAge()} 입니다!";
    }

    public void OnClickNameButton()
    {
        textLabel.text = $"저의 이름은 {GameManager.Instance.GetMyName()} 입니다!";
    }

    public void OnClickHeightButton()
    {
        textLabel.text = $"저의 키는 {GameManager.Instance.GetMyHeight()} 입니다!";
    }
    public void OnClickMbtiButton()
    {
        textLabel.text = $"저의 MBTI는 {GameManager.Instance.GetMyMBTI()} 입니다!";
    }
}
