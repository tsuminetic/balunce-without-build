using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    public playermovement move;
    public Image lose;

    public Image a;
    public Image b;
    public Image c;
    public Image win;

    private void OnCollisionEnter(Collision col) {
        if (col.collider.name=="ground"){
            if(win.enabled==false){
                move.enabled=false;
                lose.enabled=true;
                a.enabled=true;
                b.enabled=true;
                c.enabled=true;
            }
        } 
        if(col.collider.name=="tri"){
            win.enabled=true;
            a.enabled=true;
            b.enabled=true;
            c.enabled=true;
        }
    } 
}
