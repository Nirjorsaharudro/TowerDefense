using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject ui;

    public int menuSceneName = 0;
    public SceneFader sceneFader;
    void Update()
    {
        if(GameManager.GameIsOver)
            return;
        if(Input.GetKeyDown(KeyCode.Escape)|| Input.GetKeyDown(KeyCode.P)){
            Toggle();
        }
    }

    public void Toggle(){
        if(GameManager.GameIsOver)
            return;
        ui.SetActive( !ui.activeSelf );

        if(ui.activeSelf){
            Time.timeScale = 0f;
        }else{
            Time.timeScale = 1f;
        }
    }

    public void Retry(){
        Toggle();
        sceneFader.FadeTo(SceneManager.GetActiveScene().buildIndex);
        WaveSpawner.EnemiesAlive = 0;
    }

    public void Menu(){
        Toggle();
        sceneFader.FadeTo(0);
    }
}
