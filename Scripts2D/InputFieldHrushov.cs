using UnityEngine;
using UnityEngine.UI;

public class ActivateButton2 : MonoBehaviour
{
    public InputField inputField;
    public GameObject buttonNextGame;

    private void Start()
    {
        // Получаем ссылку на InputField объект на сцене
        inputField = FindObjectOfType<InputField>();

        // Назначаем метод проверки на событие изменения текста в InputField        
        inputField.onValueChanged.AddListener(OnInputFieldValueChanged);

        // Изначально деактивируем кнопку ButtonNextGame 
        buttonNextGame.SetActive(false);
    }

    private void OnInputFieldValueChanged(string value)
    {
        // Проверяем, является ли введенное слово "Сталин" 
        if (value.ToLower() == "хрущёв")
        {
            // Активируем кнопку ButtonNextGame            
            buttonNextGame.SetActive(true);
        }
        else
        {
            // Деактивируем кнопку ButtonNextGame 
            buttonNextGame.SetActive(false);
        }
    }
}
