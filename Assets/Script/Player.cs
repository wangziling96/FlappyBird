using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbodyBird;
    public Animator ani;
    public float force;
    private bool death = false;
    // Start is called before the first frame update
    void Start()
    {
        this.ani = this.GetComponent<Animator>();
        this.Idle();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.death){
            return ;
        }
        if(Input.GetMouseButtonDown(0)){
            rigidbodyBird.velocity = Vector2.zero;
            rigidbodyBird.AddForce(new Vector2(0,force));
        }
    }

    public void Idle(){
        this.rigidbodyBird.Sleep();
        this.ani.SetTrigger("Idle");
    }
    public void Fly(){
        this.rigidbodyBird.WakeUp();
        this.ani.SetTrigger("Fly");
    }
    public void Die(){
        this.death = true;
    }
    public void OnTriggerEnter2D(Collider2D other){
        this.Die();
    }
}
