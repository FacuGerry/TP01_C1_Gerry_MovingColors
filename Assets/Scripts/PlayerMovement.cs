using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public float velocity = 0.05f; //Velocidad predefinida para el movimiento
    public int rotation = 10; //Cuanto va a rotar el objeto

    //Declaracion de las teclas para poder modificarlas desde el inspector
    public KeyCode GoUp;
    public KeyCode GoDown;
    public KeyCode GoLeft;
    public KeyCode GoRight;
    public KeyCode RotateRight;
    public KeyCode RotateLeft;
    public KeyCode ChangeColor;

    void Update()
    {
        //Cada if representa el toque a una tecla, y cada uno con sus propios movimientos o transforms
        if (Input.GetKey(GoUp)) //Moverse arriba
        {
            transform.position = transform.position + new Vector3(0, velocity, 0);
        }

        if (Input.GetKey(GoDown)) //Moverse abajo
        {
            transform.position = transform.position + new Vector3(0, -velocity, 0);
        }

        if (Input.GetKey(GoLeft)) //Moverse a la izquierda
        {
            transform.position = transform.position + new Vector3(-velocity, 0, 0);
        }

        if (Input.GetKey(GoRight)) //Moverse a la derecha
        {
            transform.position = transform.position + new Vector3(velocity, 0, 0);
        }

        if (Input.GetKeyDown(RotateRight)) //Rotar a la derecha 10°
        {
            transform.Rotate(0, 0, rotation);
        }

        if (Input.GetKeyDown(RotateLeft)) //Rotar a la izquierda 10°
        {
            transform.Rotate(0, 0, -rotation);
        }

        if (Input.GetKeyUp(ChangeColor)) //Cambiar a un color random
        {
            GetComponent<SpriteRenderer>().color = Random.ColorHSV();
        }

    }
}
