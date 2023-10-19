using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    

    void Start(){
        OpenMenu();
    }
    


    static void OpenMenu(){
         SceneManager.LoadScene("_Base");
    }



    static void OpenGame(){
        SceneManager.LoadScene("Game");
        
    }

    static void fermerJeu(){

    }


}
