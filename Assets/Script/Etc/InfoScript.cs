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

    public void OnClickEyeSightButton()
    {
        textLabel.text = $"저의 시력은 좌우로 각각 {GameManager.Instance.GetMyEyeSightLeft()}, {GameManager.Instance.GetMyEyeSightRight()} 입니다!";
    }

    public void OnClickFavoriteFoodButton()
    {
        textLabel.text = $"제가 좋아하는 음식은 {GameManager.Instance.GetMyFavoriteFood()} 입니다!";
    }
    public void OnClickFavoriteColorButton()
    {
        textLabel.text = $"제가 좋아하는 색은 {GameManager.Instance.GetMyFavoriteColor()} 입니다!";
    }

    public void OnClickMyFavoriteGameGenreButton()
    {
        textLabel.text = $"제가 좋아하는 게임 장르는 {GameManager.Instance.GetMyFavoriteGameGenre()} 입니다!";
    }

    public void OnClickEducationButton()
    {
        textLabel.text = $"제 최종 학력은 {GameManager.Instance.GetMyEducation()} 입니다!";
    }

    public void OnClickBloodButton()
    {
        textLabel.text = $"제 혈액형은 {GameManager.Instance.GetMyBloodType()} 입니다!";
    }
}
