using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public int menuSceneName = 0;
   
    public SceneFader sceneFader;

    public void Retry(){
        sceneFader.FadeTo(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu(){
        sceneFader.FadeTo(menuSceneName);
    }
}
