using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private string _mainMenuName = "MainMenu";
    [SerializeField] private string _mainLevelName = "MainScene";
    [SerializeField] private string _defeatScreenName = "DefeatScreen";
    [SerializeField] private string _victoryScreenName = "VictoryScreen";

    public void ToMainMenu()
    {
        SceneManager.LoadScene(_mainMenuName);
    }

    public void ToMainLevel()
    {
        SceneManager.LoadScene(_mainLevelName);
    }

    public void ToDefeatScreen()
    {
        SceneManager.LoadScene(_defeatScreenName);
    }

    public void ToVictoryScreen()
    {
        SceneManager.LoadScene(_victoryScreenName);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                        Application.Quit();
        #endif
    }
}
