using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuS2 : MonoBehaviour
{
    //возвращаемся на главное пользовательское меню
    public void ReturnToMianMenu()
    {
        SceneManager.LoadScene(1);
    }
    //переходим на первый уровень
    public void SceneLevel1()
    {
        SceneManager.LoadScene(2);
    }

    //возвращаемся на предыдущую сцену
    public void ReturnScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    //выход из игры
    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }
    //следующая сцена
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
