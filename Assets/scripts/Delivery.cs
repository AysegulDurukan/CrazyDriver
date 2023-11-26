using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1); // arabam�z�n rengini de�i�tirmek istiyoruz.
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer; // unitydeki Sprite Renderer i cag�rmak istiyoruz ve ad�n� spriteRenderer koyuyoruz
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // oyun baslad�g�nda sprite renderera eri�mek istiyoruz.
        
    }
    public void OnCollisionEnter2D(Collision2D other) // collison2D other collisionlardan (ekledi�imiz �arp��ma �zelliklerinden) herhangibirini bir �zelli�ini vurgulamada kullan�l�r.
    { 
            Debug.Log("hata");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !hasPackage) // package true ve haspackage false ise if �al���r
        {
            Debug.Log("package pick up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);

        }

        if(other.tag == "Customer" && hasPackage) // && ifadesi if de�erinin i�indeki iki ifadede true ise sadece c�kt� verir herhangi biri veya ikiside false ise c�kt� vermez.
        {
            Debug.Log("package is ok");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }

      
        
    }

}
