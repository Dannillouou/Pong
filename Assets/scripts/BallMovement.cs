using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    void Start(){
        Launch();
    }

    float hitFactor(Vector2 bolaPos, Vector2 jogPos, float tam){
        return (bolaPos.y - jogPos.y)/tam;
    }

    void OnCollisionEnter2D(Collision2D colisao){
        if(colisao.gameObject.name == "Player1"){
            float y = hitFactor(transform.position, colisao.transform.position, colisao.collider.bounds.size.y);

            Vector2 dir = new Vector2(1,y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir*speed;
        }
        if(colisao.gameObject.name == "Player2"){
            float y = hitFactor(transform.position, colisao.transform.position, colisao.collider.bounds.size.y);

            Vector2 dir = new Vector2(-1,y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir*speed;
        }
    }

    private void Launch(){
        float x = Random.Range(0, 2) == 0 ? -1 : 1;       
        float y = Random.Range(0, 2) == 0 ? -1 : 1; 
        rb.velocity = new Vector2(speed * x, speed * y);
    }
    
    // Start is called before the first frame update
    /*void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    void OnCollisionEnter2D(Collision2D colidido){

    }*/

}
