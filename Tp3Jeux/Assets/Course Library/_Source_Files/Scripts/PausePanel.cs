using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour
{

    public void OpenPausePanel(){
        if(!gameObject.activeSelf){
             gameObject.SetActive(true);
        }else
        {
            gameObject.SetActive(false);
        }
        Time.timeScale = 1f - Time.timeScale;
        
    }


    public void QuitGame(){
        SceneNavigator.FermerJeu();
    }
    
    
    public void RetourMenu(){
        Time.timeScale = 1f - Time.timeScale;
        SceneNavigator.OpenMenu();
    }

    public void Save(){
        SaveSystem.SaveGameState(new SaveSystem.GameState{score= GameManager.instance.score, difficulte = GameManager.instance.difficulte, nbVie= GameManager.instance.nLives});
    }

}
