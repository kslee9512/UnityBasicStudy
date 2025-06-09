using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GachaController : MonoBehaviour
{
    public CharacterDataManager charDataManager;
    [SerializeField] GameObject gachaResultObj;
    [SerializeField] GameObject gachaLobbyObj;
    [SerializeField] Button danchaButton;
    [SerializeField] Button tenGachaButton;
    [SerializeField] Button returnLobbyButton;
    [SerializeField] TextMeshProUGUI gachaPointText;

    private int gachaPoint = 0;
    private float firstTierRate = 78.5f;
    private float secondTierRate = 18.5f;
    private float thirdTierRate = 3.0f;
    private void Awake()
    {
        if(charDataManager == null)
        {
            charDataManager = new CharacterDataManager();
            Debug.Log("캐릭터 데이터 초기화 완료");
            charDataManager.Init();
            gachaLobbyObj.SetActive(true);
            gachaResultObj.SetActive(false);
            gachaResultObj.GetComponent<GachaResult>().Init();
            danchaButton.onClick.AddListener(DoDancha);
            tenGachaButton.onClick.AddListener(Do10Gacha);
            returnLobbyButton.onClick.AddListener(ReturnLobby);
            UpdateGachaPointUI();
        }
    }

    public void DoDancha()
    {
        var data = GetResult();
        if((data != null))
        {
            var gachaResultUI = gachaResultObj.GetComponent<GachaResult>();
            gachaResultUI.Show1Dancha(data);
        }
        else
        {
            Debug.LogError("가챠 결과 데이터 null!");
        }
        gachaPoint += 1;
        UpdateGachaPointUI();
        gachaResultObj.SetActive(true);
        gachaLobbyObj.SetActive(false);
        
    }

    public void Do10Gacha()
    {
        bool GetOtherTier = false;
        var gachaResultUI = gachaResultObj.GetComponent<GachaResult>();
        for (int i = 0; i < 10; i++)
        {
            var charData = GetResult();
            if(charData.charGrade >= 2)
            {
                GetOtherTier = true;
            }
            if(i == 9 && GetOtherTier == false)
            {
                while(true)
                {
                    charData = GetResult();
                    if (charData.charGrade >= 2)
                        break;
                }
            }
            gachaResultUI.Show10Dancha(charData, i);
        }
        gachaPoint += 10;
        UpdateGachaPointUI();
        gachaResultObj.SetActive(true);
        gachaLobbyObj.SetActive(false);
    }

    public CharacterData GetResult()
    {
        float randValue = Random.Range(0.0f, 100.0f);
        CharacterData result;
        if(randValue < thirdTierRate)
        {
            result = charDataManager.Get3TierCharData();
        }
        else if(randValue < secondTierRate)
        {
            result = charDataManager.Get2TierCharData();
        }
        else
        {
            result = charDataManager.Get1TierCharData();
        }
        return result;
    }

    public void ReturnLobby()
    {
        gachaResultObj.SetActive(false);
        gachaLobbyObj.SetActive(true);
        gachaResultObj.GetComponent<GachaResult>().ReturnLobby();
    }

    public void UpdateGachaPointUI()
    {
        gachaPointText.text = gachaPoint.ToString();
    }
}
