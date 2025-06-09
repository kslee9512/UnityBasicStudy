using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDataManager
{
    public List<CharacterData> firstTierCharacterData;
    public List<CharacterData> secondTierCharacterData;
    public List<CharacterData> thirdTierCharacterData;

    [SerializeField] private int firstTierCharCount = 12; //총 1성 캐릭터 개수, 추가 또는 감소할 경우 해당 값도 변경
    [SerializeField] private int secondTierCharCount = 13; //총 2성 캐릭터 개수, 추가 또는 감소할 경우 해당 값도 변경
    [SerializeField] private int thirdTierCharCount = 18; //총 3성 캐릭터 개수, 추가 또는 감소할 경우 해당 값도 변경
    public void Init()
    {
        InitFirstTierCharacterData();
        InitSecondTierCharacterData();
        InitThirdTierCharacterData();
    }

    private void InitFirstTierCharacterData() //1성 캐릭터 데이터 입력
    {
        if(firstTierCharacterData == null || firstTierCharacterData.Count <= 0)
        {
            firstTierCharacterData = new List<CharacterData>(firstTierCharCount);
            CharacterData charData = new CharacterData();//기존에 저장된 값이 들어가지 않도록 초기화
            charData.InitData("마리", "Mari", 1);// InitData 안에 캐릭터 명, 이미지 파일 이름, 캐릭터 등급 입력
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("세리나", "Serina", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("스즈미", "Suzumi", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("시미코", "Shimiko", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("아스나", "Asuna", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("아카네", "Akane", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("요시미", "Yoshimi", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("주리", "Juri", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("치나츠", "Chinatsu", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("코타마", "Kotama", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("코토리", "Kotori", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("하루카", "Haruka", 1);
            firstTierCharacterData.Add(charData);

            Debug.Log("1성캐릭터 리스트 초기화 완료");
        }
    }
    private void InitSecondTierCharacterData() //2성 캐릭터 데이터 등록
    {
        if (secondTierCharacterData == null || secondTierCharacterData.Count <= 0)
        {
            secondTierCharacterData = new List<CharacterData>(secondTierCharCount);
            CharacterData charData = new CharacterData(); //기존에 저장된 값이 들어가지 않도록 초기화
            charData.InitData("아이리", "Airi", 2); // InitData 안에 캐릭터 명, 이미지 파일 이름, 캐릭터 등급 입력
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("아카리", "Akari", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("후우카", "Fuuka", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("하나에", "Hanae", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("하나코", "Hanako", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("하레", "Hare", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("하스미", "Hasumi", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("준코", "Junko", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("카요코", "Kayoko", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("모모이", "Momoi", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("무츠키", "Mutsuki", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("우타하", "Utaha", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("유우카", "Yuuka", 2);
            secondTierCharacterData.Add(charData);
            Debug.Log("2성캐릭터 리스트 초기화 완료");
        }
    }
    private void InitThirdTierCharacterData() //3성 캐릭터 등록
    {
        if (thirdTierCharacterData == null || thirdTierCharacterData.Count <= 0)
        {
            thirdTierCharacterData = new List<CharacterData>(thirdTierCharCount);//기존에 저장된 값이 들어가지 않도록 초기화
            CharacterData charData = new CharacterData();// InitData 안에 캐릭터 명, 이미지 파일 이름, 캐릭터 등급 입력
            charData.InitData("아코", "Ako", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("아리스", "Arisu", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("아루", "Aru", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("치히로", "Chihiro", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("하루나", "Haruna", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("히비키", "Hibiki", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("히나", "Hina", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("히나타", "Hinata", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("이오리", "Iori", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("이즈미", "Izumi", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("카린", "Karin", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("마키", "Maki", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("마시로", "Mashiro", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("미도리", "Midori", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("나츠", "Natsu", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("네루", "Neru", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("츠루기", "Tsurugi", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("유즈", "Yuzu", 3);
            thirdTierCharacterData.Add(charData);
            Debug.Log("3성캐릭터 리스트 초기화 완료");
        }
    }

    public CharacterData Get1TierCharData()
    {
        int randNum = Random.Range(0, firstTierCharacterData.Count);
        if (firstTierCharacterData[randNum] != null)
        {
            Debug.Log("결과값 : " + firstTierCharacterData[randNum].charName);
            return firstTierCharacterData[randNum];
        }
        else
        {
            return null;
        }
    }
    public CharacterData Get2TierCharData()
    {
        int randNum = Random.Range(0, secondTierCharacterData.Count);
        if (secondTierCharacterData[randNum] != null)
        {
            Debug.Log("결과값 : " + secondTierCharacterData[randNum].charName);
            return secondTierCharacterData[randNum];
        }
        else
        {
            return null;
        }
    }
    public CharacterData Get3TierCharData()
    {
        int randNum = Random.Range(0, thirdTierCharacterData.Count);
        if (thirdTierCharacterData[randNum] != null)
        {
            Debug.Log("결과값 : " + thirdTierCharacterData[randNum].charName);
            return thirdTierCharacterData[randNum];
        }
        else
        {
            return null;
        }
    }
}
