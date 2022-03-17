using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void Playgame(){
        SceneManager.LoadScene(1);
    }
    public void Endgame(){
        Application.Quit();
    }
    public void backbut(){
        SceneManager.LoadScene(0);
    }
}
