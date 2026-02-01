using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
   public float speed = 1.0f;
    public float destroy = -12f;
   private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < destroy) Destroy(gameObject);
    }
}
