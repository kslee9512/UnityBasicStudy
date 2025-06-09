using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GachaResult : MonoBehaviour
{
    [SerializeField] List<GameObject> resultSlot;
    [SerializeField] List<Vector2> slotPos;
    public void Init()
    {
        if(resultSlot == null || resultSlot.Count <= 0)
        {
            resultSlot = new List<GameObject>(10);
            var cloneObj = Resources.Load<GameObject>("Prefab/GachaResultSlot");
            for(int i = 0; i < 10; i++)
            {
                var gameObj = Instantiate(cloneObj, this.transform);
                gameObj.SetActive(false);
                resultSlot.Add(gameObj);
            }
        }
        if (slotPos == null || slotPos.Count <= 0)
        {
            slotPos = new List<Vector2>(10);
            for (int i = 0; i < 10; i++)
            {
                Vector2 newVector = Vector2.zero;
                if ( i < 5)
                {
                    newVector = new Vector2(-720f + (350 * i), 350f);
                }
                else
                {
                    newVector = new Vector2(-720f + (350 * (i % 5)), 0f);
                }
                slotPos.Add(newVector);
            }
        }
    }

    public void Show1Dancha(CharacterData CharData)
    {
        Vector2 slotPos = new Vector2(0, 0);
        var slotData = resultSlot[0].GetComponent<GachaResultSlot>();
        slotData.InitSlotData(CharData);
        slotData.InitPos(slotPos);
        resultSlot[0].SetActive(true);
    }

    public void Show10Dancha(CharacterData CharData, int listIdx)
    {
        var slotData = resultSlot[listIdx].GetComponent<GachaResultSlot>();
        slotData.InitSlotData(CharData);
        slotData.InitPos(slotPos[listIdx]);
        resultSlot[listIdx].SetActive(true);
    }

    public void ReturnLobby()
    {
        for(int i = 0; i < resultSlot.Count; i++)
        {
            resultSlot[i].SetActive(false);
        }
    }
}
