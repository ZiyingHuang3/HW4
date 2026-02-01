using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioClip flapSound;
    public AudioClip scoreSound;
    public AudioClip dieSound;

    AudioSource audioSource;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        GameEvent.Flap += PlayFlap;
        GameEvent.OnScored += PlayScore;
        GameEvent.Died += PlayDie;
    }

    void OnDisable()
    {
        GameEvent.Flap -= PlayFlap;
        GameEvent.OnScored -= PlayScore;
        GameEvent.Died -= PlayDie;
    }

    void PlayFlap()
    {
        audioSource.PlayOneShot(flapSound);
    }

    void PlayScore()
    {
        audioSource.PlayOneShot(scoreSound);
    }

    void PlayDie()
    {
        audioSource.PlayOneShot(dieSound);
    }
}
