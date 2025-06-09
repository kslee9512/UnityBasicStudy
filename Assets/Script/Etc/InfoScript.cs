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
    [SerializeField] Button bloodTypeButton;
    [SerializeField] Button eyesightButton;
    [SerializeField] Button favoriteFoodButton;
    [SerializeField] Button educationButton;
    [SerializeField] Button favoriteGameGenreButton;
    [SerializeField] Button favoriteColor;
    [SerializeField] TextMeshProUGUI textLabel;

    private void Awake()
    {
        ageButton.onClick.AddListener(OnClickAgeButton);
        nameButton.onClick.AddListener(OnClickNameButton);
        heightButton.onClick.AddListener(OnClickHeightButton);
        mbtiButton.onClick.AddListener(OnClickMbtiButton);
        bloodTypeButton.onClick.AddListener(OnClickBloodButton);
        eyesightButton.onClick.AddListener(OnClickEyeSightButton);
        favoriteFoodButton.onClick.AddListener(OnClickFavoriteFoodButton);
        educationButton.onClick.AddListener(OnClickEducationButton);
        favoriteGameGenreButton.onClick.AddListener(OnClickMyFavoriteGameGenreButton);
        favoriteColor.onClick.AddListener(OnClickFavoriteColorButton);
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

    public void OnClickEyeSightButton()
    {
        textLabel.text = $"���� �÷��� �¿�� ���� {GameManager.Instance.GetMyEyeSightLeft()}, {GameManager.Instance.GetMyEyeSightRight()} �Դϴ�!";
    }

    public void OnClickFavoriteFoodButton()
    {
        textLabel.text = $"���� �����ϴ� ������ {GameManager.Instance.GetMyFavoriteFood()} �Դϴ�!";
    }
    public void OnClickFavoriteColorButton()
    {
        textLabel.text = $"���� �����ϴ� ���� {GameManager.Instance.GetMyFavoriteColor()} �Դϴ�!";
    }

    public void OnClickMyFavoriteGameGenreButton()
    {
        textLabel.text = $"���� �����ϴ� ���� �帣�� {GameManager.Instance.GetMyFavoriteGameGenre()} �Դϴ�!";
    }

    public void OnClickEducationButton()
    {
        textLabel.text = $"�� ���� �з��� {GameManager.Instance.GetMyEducation()} �Դϴ�!";
    }

    public void OnClickBloodButton()
    {
        textLabel.text = $"�� �������� {GameManager.Instance.GetMyBloodType()} �Դϴ�!";
    }
}
