using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fall : MonoBehaviour
{
    public Transform player;
    //public Text win;
    public Image lose;
    
    public Image a;
    public Image b;
    public Image c;
    public Image win;
    void Update()
    {
        if(player.position.y<-2f){
            if(win.enabled==false){
                lose.enabled=true;
                a.enabled=true;
                b.enabled=true;
                c.enabled=true;
            }
            
        }
    }
}
