using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1); // arabamýzýn rengini deðiþtirmek istiyoruz.
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer; // unitydeki Sprite Renderer i cagýrmak istiyoruz ve adýný spriteRenderer koyuyoruz
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // oyun basladýgýnda sprite renderera eriþmek istiyoruz.
        
    }
    public void OnCollisionEnter2D(Collision2D other) // collison2D other collisionlardan (eklediðimiz çarpýþma özelliklerinden) herhangibirini bir özelliðini vurgulamada kullanýlýr.
    { 
            Debug.Log("hata");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !hasPackage) // package true ve haspackage false ise if çalýþýr
        {
            Debug.Log("package pick up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);

        }

        if(other.tag == "Customer" && hasPackage) // && ifadesi if deðerinin içindeki iki ifadede true ise sadece cýktý verir herhangi biri veya ikiside false ise cýktý vermez.
        {
            Debug.Log("package is ok");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }

      
        
    }

}
