using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //подт€гиваем следующую сцену после меню 
        Debug.Log("Start game...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitGame()
    {
        // выкидываем нашу игру в урну
        Debug.Log("Closing game...");
        Application.Quit();
    }
}
