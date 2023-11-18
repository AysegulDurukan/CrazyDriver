using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //kamerayla arabam�z�n ayn� pozisyonda olmas�n� istiyoruz fakat kameran�n z ekseninde araban�n �st�nde olmas� gerekir yoksa 
    //kamera sadece s�yah ekran ver�r yan� araban�n i�ine girmi� oluyor.
    [SerializeField] GameObject thingToFollow;
    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
