using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    public static event Action<int> OnScoreChanged;
    public static event Action OnScored;
    public static event Action Flap;
    public static event Action Died;

    public static void AddScore(int newScore){ OnScoreChanged?.Invoke(newScore); }
    public static void RaiseScore(){ OnScored?.Invoke(); }
    public static void RaiseFlap() { Flap?.Invoke(); }
    public static void RaiseDied() { Died?.Invoke(); }  

}
