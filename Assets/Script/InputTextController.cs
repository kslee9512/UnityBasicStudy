using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class InputTextController : MonoBehaviour
{
    [SerializeField] TMP_InputField inputText; // ����ڰ� �Է��� �ؽ�Ʈ
    [SerializeField] TextMeshProUGUI printText; // �ؽ�Ʈ�� ����� ������Ʈ
    [SerializeField] Button inputButton; //��ư

    private void Awake()
    {
        inputButton.onClick.AddListener(ChangeTextLabel); // OnClick�� ��� ����.
    }

    public void ChangeTextLabel()
    {
        printText.text = inputText.text; // inputField�� �Էµ� Text�� ����� �ؽ�Ʈ�� ����־��.
    }
}
