using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] float speed = 50f;
    [SerializeField] float rotationSpeed = 50f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * -speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            //esquerda
            transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
        }else if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            //direita

            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }
}
