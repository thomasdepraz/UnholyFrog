using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [NaughtyAttributes.Scene]
    public int startSceneBuildIndex;

    public void Play()
    {
        SceneManager.LoadScene(startSceneBuildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
