using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //����������� ��������� ����� ����� ���� 
        Debug.Log("Start game...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitGame()
    {
        // ���������� ���� ���� � ����
        Debug.Log("Closing game...");
        Application.Quit();
    }
}
