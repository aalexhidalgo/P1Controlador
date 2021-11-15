using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Speed = 20;
    private float TurnSpeed = 10;
    private float HorizontalInput;
    private float VerticalInput;
   
    void Update()
    {
        //Tomamos el eje horizontal del Input Manager
        HorizontalInput = Input.GetAxis("Horizontal");
        //Tomamos el eje vertical del Input Manager
        VerticalInput = Input.GetAxis("Vertical");

        //Movimiento hacia adelante
        transform.Translate(Vector3.forward * Speed * Time.deltaTime * VerticalInput);

        //Movimiento hacia los lados
        transform.Translate(Vector3.right * TurnSpeed * Time.deltaTime * HorizontalInput);

        //Rotación
        transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime * HorizontalInput);
    }
}
