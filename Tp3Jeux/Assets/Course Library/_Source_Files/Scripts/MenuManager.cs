using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    //SceneNavigator sceneNavigator;

    public GameObject buttonContinuer;

    private SaveSystem.GameState gameState;

    private bool hasGameState;

    void Start(){
        //sceneNavigator = GetComponent<SceneNavigator>();
        
        gameState = SaveSystem.CheckAndLoadGameStateData();


        if(gameState==null){
            hasGameState = false;
            buttonContinuer.SetActive(false);
        }else{
            hasGameState = true;
        }

    }

    public void continuer(){
        
        if(hasGameState){
            SceneNavigator.OpenGame();
        }
    }

    public void nouvellePartie(){
        SceneNavigator.OpenGame();
    }

    public void parametre(){

    }

    public void quitter(){
        SceneNavigator.FermerJeu();
    }
}
