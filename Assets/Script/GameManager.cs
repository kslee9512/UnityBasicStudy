using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] MyInfoClass myInfoClass;
    private static GameManager instance;
    private void Awake()
    {
        myInfoClass = new MyInfoClass();
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static GameManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    public string GetMyName()
    {
        if(myInfoClass != null)
        {
            return myInfoClass.GetMyName();
        }
        else
        {
            return string.Empty;
        }
    }

    public string GetMyMBTI()
    {
        if (myInfoClass != null)
        {
            return myInfoClass.GetMyMBTI();
        }
        else
        {
            return string.Empty;
        }
    }

    public int GetMyAge()
    {
        if (myInfoClass != null)
        {
            return myInfoClass.GetMyAge();
        }
        else
        {
            return 0;
        }
    }

    public int GetMyHeight()
    {
        if (myInfoClass != null)
        {
            return myInfoClass.GetMyHeight();
        }
        else
        {
            return 0;
        }
    }
}
