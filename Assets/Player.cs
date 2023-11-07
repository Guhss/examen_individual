using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public float velocidadRotacion = 80f;

    private void Update()
    {
        
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(0f, 0f, movimientoVertical) * velocidadMovimiento * Time.deltaTime;
        Vector3 rotacion = new Vector3(0f, movimientoHorizontal, 0f) * velocidadRotacion * Time.deltaTime;

        transform.Translate(movimiento);
        transform.Rotate(rotacion);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tienda"))
        {
            
        }
        else 

        if (other.CompareTag("Corral"))
        {
            
        }
        else 

        if (other.CompareTag("Huerto"))
        {
            
        }
    }
}
