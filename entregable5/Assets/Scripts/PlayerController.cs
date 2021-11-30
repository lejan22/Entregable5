using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //velocidad avioneta
    public float speed = 12f;
    //velocidad de subida
    public float turnSpeed = 70f;
    //subir avioneta
    public float verticalInput;
    //altura max
    private float zMax = 450f;
    // Start is called before the first frame update
    void Start()
    {
        //posicion inicial
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //al perder aparecer game over
        if (transform.position.z > zMax)
        {
            Debug.Log("SE ACABO");
            Time.timeScale = 0;
        }
        //para que al presionar arriba el avion vaya arriba
        verticalInput = Input.GetAxis("Vertical");

        //funcion para que siga hacia delante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
         //funcion para que rote
        transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime * verticalInput);
    }
}
