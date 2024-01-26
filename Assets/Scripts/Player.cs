

using System;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{ 
    private static int coin;
    [SerializeField] private Text myCoin;

    private void Start()
    {
        coin = 0;
    }

    private void Update()
    {
        myCoin.text = "Coin: " + coin;
    }1

    public static int Coin
    {
        get => coin;
        set => coin = value;
    }
}