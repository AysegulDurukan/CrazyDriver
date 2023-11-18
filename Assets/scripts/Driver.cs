using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] public float moveSpeed = 0.01f;
    [SerializeField] float slowSpeed = 4f;
    [SerializeField] public float boostSpeed = 15f;

 
   
    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime ;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;


        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }

    public void OnCollisionEnter2D(Collision2D other) // herhangi bir nesneye �arpt�g�nda h�z�m� yavaslayan h�zla de�i�cek
    {
        moveSpeed = slowSpeed;
    }

    public void OnTriggerEnter2D(Collider2D other) // colliider i istrigger  olarak se�ili bir nesneye carpt�g�m�zda h�z�m� de�i�ecek
    {
        if(other.tag == "boost")
        {
            moveSpeed = boostSpeed;
        }

        
    }
}
