using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float hareketHizi = 4f;
    public float ziplamaGucu = 8f;
    private bool havadaMi = false;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        float yatayHareket = Input.GetAxis("Horizontal");
        float dikeyHareket = Input.GetAxis("Vertical");

        Vector3 hareketVektoru = new Vector3(yatayHareket, 0f, dikeyHareket) * hareketHizi * Time.deltaTime;
        transform.Translate(hareketVektoru);

        if (Input.GetKeyDown(KeyCode.Space) && !havadaMi) 
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * ziplamaGucu, ForceMode.Impulse);
            havadaMi = true;
        }        
        
        // float hareketMiktari = hareketHizi * Time.deltaTime;
        // if (Input.GetKey(KeyCode.W))
        // {
        //     transform.Translate(Vector3.forward * hareketMiktari);
        // }
        // if (Input.GetKey(KeyCode.D))
        // {
        //     transform.Translate(Vector3.right * hareketMiktari);
        // }
        // if (Input.GetKey(KeyCode.A))
        // {
        //     transform.Translate(Vector3.left * hareketMiktari);
        // }
        // if (Input.GetKey(KeyCode.S))
        // {
        //     transform.Translate(Vector3.back * hareketMiktari);
        // }
    }

    private void OnCollisionEnter(Collision temas)
    {
        if (temas.gameObject.CompareTag("Zemin"))
        {
            havadaMi = false;
        }
    }
}
