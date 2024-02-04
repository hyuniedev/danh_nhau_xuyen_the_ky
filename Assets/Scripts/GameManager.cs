using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int coin;

    private void Start()
    {
        coin = 0;
        
    }

    public static int Coin
    {
        get => coin;
        set => coin = value;
    }
}
