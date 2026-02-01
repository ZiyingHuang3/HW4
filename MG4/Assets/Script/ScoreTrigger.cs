using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreTrigger : MonoBehaviour
{
    bool scored = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (scored) return;

        if (other.CompareTag("Player"))
        {
            scored = true;
            ScoreManager.Instance.AddPoint();
        }
    }
}
