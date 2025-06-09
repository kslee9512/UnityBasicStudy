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
            charDataManager.Init(); // 캐릭터 데이터 초기화 시키기
            gachaLobbyObj.SetActive(true); // 가챠 로비화면 켜기
            gachaResultObj.SetActive(false); // 가챠 결과화면 끄기
            gachaResultObj.GetComponent<GachaResult>().Init(); // 가챠 결과화면의 캐릭터 슬롯 오브젝트 초기화
            danchaButton.onClick.AddListener(DoDancha); //단챠 버튼 기능 추가
            tenGachaButton.onClick.AddListener(Do10Gacha); // 10연차 버튼 기능 추가
            returnLobbyButton.onClick.AddListener(ReturnLobby); // 로비로 돌아가기 버튼 기능 추가
            UpdateGachaPointUI(); //모집 포인트 UI 초기화
        }
    }

    public void DoDancha() // 1회 모집
    {
        var data = GetResult(); // 가챠 결과 받아오기
        if((data != null)) // 데이터 결과값에 오류가 없으면
        {
            var gachaResultUI = gachaResultObj.GetComponent<GachaResult>();
            gachaResultUI.Show1Dancha(data); //가챠 결과 보여주기
        }
        else
        {
            Debug.LogError("가챠 결과 데이터 null!"); //가챠 데이터 결과값 디버그용
        }
        gachaPoint += 1; // 모집포인트 증가
        UpdateGachaPointUI(); // 모집포인트 UI 업데이트
        gachaResultObj.SetActive(true); // 가챠 결과화면 띄우기
        gachaLobbyObj.SetActive(false); // 로비 화면 끄기
        
    }

    public void Do10Gacha() // 10회 모집 진행
    {
        bool GetOtherTier = false; //10회 돌리는 동안 2성 이상이 한번도 안떴는지 체크용
        var gachaResultUI = gachaResultObj.GetComponent<GachaResult>();
        for (int i = 0; i < 10; i++) // 10번 실행해라.
        {
            var charData = GetResult(); // 가챠 결과값 가져오기.
            if(charData.charGrade >= 2) // 가챠 결과값에 2성 이상 캐릭터가 있을 경우 마지막 캐릭터 2성 보장 안시켜도 되게 처리.
            {
                GetOtherTier = true;
            }
            if(i == 9 && GetOtherTier == false) // 가챠 10번째 까지 2성 이상이 하나도 안떳을 경우
            {
                while(true) // 2성 이상이 나올 때 까지 반복
                {
                    charData = GetResult();
                    if (charData.charGrade >= 2)
                        break; // 2성 이상이 떳으니 while 탈출
                }
            }
            gachaResultUI.Show10Dancha(charData, i); // 가챠 결과화면 출력
        }
        gachaPoint += 10; // 모집 포인트 상승
        UpdateGachaPointUI(); // 모집 포인트 UI 업데이트
        gachaResultObj.SetActive(true); // 가챠 결과화면 보여주기
        gachaLobbyObj.SetActive(false); // 가챠 로비화면 가리기
    }

    public CharacterData GetResult()
    {
        float randValue = Random.Range(0.0f, 100.0f); // 0에서 100까지의 값 랜덤하게 출력
        CharacterData result;
        if(randValue < thirdTierRate) // 랜덤값이 0.3보다 낮을 경우, 3%의 확률에 들어가는 확률이므로 3성 캐릭터 지급
        {
            result = charDataManager.Get3TierCharData();
        }
        else if(randValue < secondTierRate) // 랜덤값이 18.5보다 낮을 경우, 2성 캐릭터 지급, 이때 0.3보다 적은 값은 앞선 if에서 체크 걸렸으므로 무시
        {
            result = charDataManager.Get2TierCharData();
        }
        else // 모두 해당 아니므로 1성 캐릭터 지급
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
