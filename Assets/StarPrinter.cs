using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class StarPrinter : MonoBehaviour
{
    [SerializeField] Button[] phaseButton;
    [SerializeField] TextMeshProUGUI textLabel;
    private void Awake()
    {
        phaseButton[0].onClick.AddListener(Phase1);
        phaseButton[1].onClick.AddListener(Phase2);
        phaseButton[2].onClick.AddListener(Phase3);
        phaseButton[3].onClick.AddListener(Phase4);
        phaseButton[4].onClick.AddListener(Phase5);
    }
    public void Phase1()
    {
        string text = string.Empty;
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < i + 1; j++)
            {
                text += "¡Ú ";
            }
            text += "\n";
        }
        textLabel.alignment = TextAlignmentOptions.Left;
        textLabel.text = text;  
    }

    public void Phase2()
    {
        string text = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 4; j > i - 1; j--)
            {
                text += "¡Ú ";
            }
            text += "\n";
        }
        textLabel.alignment = TextAlignmentOptions.Left;
        textLabel.text = text;
    }
    public void Phase3()
    {
        string text = string.Empty;
        for (int i = 0; i < 10; i++)
        {
            if(i < 5)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    text += "¡Ú ";
                }
            }
            else
            {
                for(int j = 0; j < 9 - i; j++)
                {
                    text += "¡Ú ";
                }
            }
            text += "\n";
        }
        textLabel.alignment = TextAlignmentOptions.Left;
        textLabel.text = text;
    }
    public void Phase4()
    {
        string text = string.Empty;
        for (int i = 0; i < 10; i++)
        {
            if(i < 5)
            {
                for(int j = 4; j > i; j--)
                {
                    text += "   ";
                }
                for(int j = 0; j < i + 1; j++)
                {
                    text += "¡Ú";
                }
            }
            else
            {
                for(int j = 0; j < i - 4; j++)
                {
                    text += "   "; 
                }
                for(int j = 0; j < 9 - i; j++)
                {
                    text += "¡Ú";
                }
            }
            text += "\n";
        }
        textLabel.alignment = TextAlignmentOptions.Left;
        textLabel.text = text;
    }
    public void Phase5()
    {
        string text = string.Empty;
        for(int i = 0; i < 9; i++)
        {
            if(i < 5)
            {
                for (int j = 0; j < (2 * i) + 1; j++)
                {
                    text += "¡Ú ";
                }
            }
            else
            {
                for(int j = 0; j < 17 - (2 * i); j++)
                {
                    text += "¡Ú ";
                }
            }
            text += "\n";
        }
        textLabel.alignment = TextAlignmentOptions.Center;
        textLabel.text = text;
    }
}
