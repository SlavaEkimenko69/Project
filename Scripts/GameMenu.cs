using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    bool ���������;
    private void Start()
    {
        ��������� = false;
    }

    private void FixedUpdate()
    {
       
    }
    public void ���������()
    {
        SceneManager.LoadScene("���������", LoadSceneMode.Single);
    }
    public void ���������()
    {
        SceneManager.LoadScene("������� ����", LoadSceneMode.Single);
    }
    public void �����()
    {
        Application.Quit();
    }
}

