using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieCarScript : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float rotationSpeed = 1f;
    [SerializeField] List<Transform> alvos;
    [SerializeField] Transform direcao;
    Rigidbody rb;
    Vector3 direction;
    int index;
    void Start()
    {
        index = 0;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, alvos[index].position, speed * Time.deltaTime);



        if (Vector3.Distance(transform.position, alvos[index].position) < 2f)
        {
            if(index < alvos.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }
        var dir = alvos[index].position - transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.LookAt(alvos[index].position,Vector3.up);
    }
}
