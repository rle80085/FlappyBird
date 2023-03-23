using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMechanics : MonoBehaviour
{

    public float speed = 5;

    private void Awake()
    {

    }
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -26) Destroy(gameObject);

       }

}
