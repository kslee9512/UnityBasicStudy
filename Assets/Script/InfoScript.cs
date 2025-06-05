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
        textLabel.text = "������ �ñ��Ѱ���?";
    }

    public void OnClickAgeButton()
    {
        textLabel.text = $"���� ���̴� {GameManager.Instance.GetMyAge()} �Դϴ�!";
    }

    public void OnClickNameButton()
    {
        textLabel.text = $"���� �̸��� {GameManager.Instance.GetMyName()} �Դϴ�!";
    }

    public void OnClickHeightButton()
    {
        textLabel.text = $"���� Ű�� {GameManager.Instance.GetMyHeight()} �Դϴ�!";
    }
    public void OnClickMbtiButton()
    {
        textLabel.text = $"���� MBTI�� {GameManager.Instance.GetMyMBTI()} �Դϴ�!";
    }
}
