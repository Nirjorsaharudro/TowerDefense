using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public int menuSceneName = 0;

    public int nextLevel = 3;
    public int levelToUnlock = 2;

    public SceneFader sceneFader;

    public void Continue(){
        if(levelToUnlock > PlayerPrefs.GetInt("levelReached")){
           PlayerPrefs.SetInt("levelReached", levelToUnlock);
        }
        
        sceneFader.FadeTo(nextLevel);
        nextLevel++;
        levelToUnlock++;
    }

    public void Menu(){
        sceneFader.FadeTo(0);
    }

    public void Back(){
        sceneFader.FadeTo(1);
    }
   
}
