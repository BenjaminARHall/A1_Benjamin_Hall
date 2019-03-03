using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        Screen.SetResolution(1080, 810, false);

    }
}
