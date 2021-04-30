using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int levelToLoad = 1;

    public SceneFader sceneFader;
    public void Play(){
        sceneFader.FadeTo(levelToLoad);
    }

    public void Quit(){
        Debug.Log("Exciting....");
        Application.Quit();
    }
}
