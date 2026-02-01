using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public int Score { get; private set; } = 0;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        GameEvent.AddScore(Score);
    }

    public void AddPoint(int amount = 1)
    {
        Score += amount;
        GameEvent.AddScore(Score);
        GameEvent.RaiseScore();
    }
}
