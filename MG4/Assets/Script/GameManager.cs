using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] GameObject GameOverUI;
    bool isGameOver = false;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex
        );
    }

    void OnEnable()
    {
        GameEvent.Died += GameOver;
    }

    void OnDisable()
    {
        GameEvent.Died -= GameOver;
    }

    void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;

        if (GameOverUI != null)
            GameOverUI.SetActive(true);

        Time.timeScale = 0f;
    }
}
