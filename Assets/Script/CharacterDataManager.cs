using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDataManager
{
    public List<CharacterData> firstTierCharacterData;
    public List<CharacterData> secondTierCharacterData;
    public List<CharacterData> thirdTierCharacterData;

    [SerializeField] private int firstTierCharCount = 12;
    [SerializeField] private int secondTierCharCount = 13;
    [SerializeField] private int thirdTierCharCount = 18;
    public void Init()
    {
        InitFirstTierCharacterData();
        InitSecondTierCharacterData();
        InitThirdTierCharacterData();
    }

    private void InitFirstTierCharacterData()
    {
        if(firstTierCharacterData == null || firstTierCharacterData.Count <= 0)
        {
            firstTierCharacterData = new List<CharacterData>(firstTierCharCount);
            CharacterData charData = new CharacterData();
            charData.InitData("����", "Mari", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("������", "Serina", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�����", "Suzumi", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�ù���", "Shimiko", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�ƽ���", "Asuna", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("��ī��", "Akane", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("��ù�", "Yoshimi", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�ָ�", "Juri", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("ġ����", "Chinatsu", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("��Ÿ��", "Kotama", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("���丮", "Kotori", 1);
            firstTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�Ϸ�ī", "Haruka", 1);
            firstTierCharacterData.Add(charData);

            Debug.Log("1��ĳ���� ����Ʈ �ʱ�ȭ �Ϸ�");
        }
    }
    private void InitSecondTierCharacterData()
    {
        if (secondTierCharacterData == null || secondTierCharacterData.Count <= 0)
        {
            secondTierCharacterData = new List<CharacterData>(secondTierCharCount);
            CharacterData charData = new CharacterData();
            charData.InitData("���̸�", "Airi", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("��ī��", "Akari", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�Ŀ�ī", "Fuuka", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�ϳ���", "Hanae", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�ϳ���", "Hanako", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�Ϸ�", "Hare", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�Ͻ���", "Hasumi", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("����", "Junko", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("ī����", "Kayoko", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�����", "Momoi", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("����Ű", "Mutsuki", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("��Ÿ��", "Utaha", 2);
            secondTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("����ī", "Yuuka", 2);
            secondTierCharacterData.Add(charData);
            Debug.Log("2��ĳ���� ����Ʈ �ʱ�ȭ �Ϸ�");
        }
    }
    private void InitThirdTierCharacterData()
    {
        if (thirdTierCharacterData == null || thirdTierCharacterData.Count <= 0)
        {
            thirdTierCharacterData = new List<CharacterData>(thirdTierCharCount);
            CharacterData charData = new CharacterData();
            charData.InitData("����", "Ako", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�Ƹ���", "Arisu", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�Ʒ�", "Aru", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("ġ����", "Chihiro", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�Ϸ糪", "Haruna", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("����Ű", "Hibiki", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("����", "Hina", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("����Ÿ", "Hinata", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�̿���", "Iori", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�����", "Izumi", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("ī��", "Karin", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("��Ű", "Maki", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("���÷�", "Mashiro", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�̵���", "Midori", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("����", "Natsu", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�׷�", "Neru", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("�����", "Tsurugi", 3);
            thirdTierCharacterData.Add(charData);
            charData = new CharacterData();
            charData.InitData("����", "Yuzu", 3);
            thirdTierCharacterData.Add(charData);
            Debug.Log("3��ĳ���� ����Ʈ �ʱ�ȭ �Ϸ�");
        }
    }

    public CharacterData Get1TierCharData()
    {
        int randNum = Random.Range(0, firstTierCharacterData.Count);
        if (firstTierCharacterData[randNum] != null)
        {
            Debug.Log("����� : " + firstTierCharacterData[randNum].charName);
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
            Debug.Log("����� : " + secondTierCharacterData[randNum].charName);
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
            Debug.Log("����� : " + thirdTierCharacterData[randNum].charName);
            return thirdTierCharacterData[randNum];
        }
        else
        {
            return null;
        }
    }
}
