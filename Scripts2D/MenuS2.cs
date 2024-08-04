using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuS2 : MonoBehaviour
{
    //������������ �� ������� ���������������� ����
    public void ReturnToMianMenu()
    {
        SceneManager.LoadScene(1);
    }
    //��������� �� ������ �������
    public void SceneLevel1()
    {
        SceneManager.LoadScene(2);
    }

    //������������ �� ���������� �����
    public void ReturnScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    //����� �� ����
    public void ExitGame()
    {
        Debug.Log("���� ���������");
        Application.Quit();
    }
    //��������� �����
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
