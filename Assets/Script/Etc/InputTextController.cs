using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class InputTextController : MonoBehaviour
{
    [SerializeField] TMP_InputField inputText; // 사용자가 입력한 텍스트
    [SerializeField] TextMeshProUGUI printText; // 텍스트를 출력할 오브젝트
    [SerializeField] Button inputButton; //버튼

    private void Awake()
    {
        inputButton.onClick.AddListener(ChangeTextLabel); // OnClick에 기능 적용.
    }

    public void ChangeTextLabel()
    {
        printText.text = inputText.text; // inputField에 입력된 Text를 출력할 텍스트에 집어넣어라.
    }
}
