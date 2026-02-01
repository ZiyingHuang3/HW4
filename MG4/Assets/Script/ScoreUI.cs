using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
   [SerializeField] private TMP_Text pointText;

    void OnEnable()
    {
        GameEvent.OnScoreChanged += Refresh;
    }

    void OnDisable()
    {
        GameEvent.OnScoreChanged -= Refresh;
    }

    void Refresh(int score)
    {
        if (pointText != null)
            pointText.text = score.ToString();
    }
}
