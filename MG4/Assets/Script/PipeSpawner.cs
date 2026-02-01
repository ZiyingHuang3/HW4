using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float interval = 1.5f;
    public float minY = -2f;
    public float maxY = 2f;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            timer = 0f;
            float y = Random.Range(minY, maxY);
            Instantiate(pipePrefab, new Vector3(transform.position.x, y, 0f), Quaternion.identity);
        }
    }
}
