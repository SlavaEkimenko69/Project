using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    bool настройки;
    private void Start()
    {
        настройки = false;
    }

    private void FixedUpdate()
    {
       
    }
    public void Настройки()
    {
        SceneManager.LoadScene("Настройки", LoadSceneMode.Single);
    }
    public void Вернуться()
    {
        SceneManager.LoadScene("Главное меню", LoadSceneMode.Single);
    }
    public void Выход()
    {
        Application.Quit();
    }
}

