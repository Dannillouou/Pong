using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //public string axis;
    public float speed = 10.0f;
    public bool ehPlayer1;

    private float movimento;

    void Update(){
        if(ehPlayer1){
            movimento = Input.GetAxisRaw("Vertical");
        }
        else{
            movimento = Input.GetAxisRaw("Vertical2");
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, movimento * speed);// x eh 0 pq so ha movimento na vertical
    }
}
