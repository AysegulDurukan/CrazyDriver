using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //kamerayla arabamýzýn ayný pozisyonda olmasýný istiyoruz fakat kameranýn z ekseninde arabanýn üstünde olmasý gerekir yoksa 
    //kamera sadece sýyah ekran verýr yaný arabanýn içine girmiþ oluyor.
    [SerializeField] GameObject thingToFollow;
    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
