using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    

    void Start(){
        if (SceneManager.GetActiveScene().name != "_Base")
        {
            OpenMenu();
        }
    }

     public static void OpenMenu(){
         SceneManager.LoadScene("_Base");
    }



    public static void OpenGame(){
        SceneManager.LoadScene("Game");
    }

    public static void FermerJeu(){
        SceneManager.UnloadSceneAsync("_Base");
        Application.Quit();
    }


}
