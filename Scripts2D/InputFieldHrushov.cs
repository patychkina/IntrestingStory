using UnityEngine;
using UnityEngine.UI;

public class ActivateButton2 : MonoBehaviour
{
    public InputField inputField;
    public GameObject buttonNextGame;

    private void Start()
    {
        // �������� ������ �� InputField ������ �� �����
        inputField = FindObjectOfType<InputField>();

        // ��������� ����� �������� �� ������� ��������� ������ � InputField        
        inputField.onValueChanged.AddListener(OnInputFieldValueChanged);

        // ���������� ������������ ������ ButtonNextGame 
        buttonNextGame.SetActive(false);
    }

    private void OnInputFieldValueChanged(string value)
    {
        // ���������, �������� �� ��������� ����� "������" 
        if (value.ToLower() == "������")
        {
            // ���������� ������ ButtonNextGame            
            buttonNextGame.SetActive(true);
        }
        else
        {
            // ������������ ������ ButtonNextGame 
            buttonNextGame.SetActive(false);
        }
    }
}
