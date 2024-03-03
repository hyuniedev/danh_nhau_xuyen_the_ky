using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float maxTime;
    [SerializeField] private Text txtCoin;
    private static int coin;
    public static QueueHeroDied _queueHeroDied = new QueueHeroDied();

    private void Start()
    {
        // set begin coin
        coin = 100;
    }

    private void Update()
    {
        this.txtCoin.text = "Coin : " + coin;
    }
    
    public static void IncCoin(int coin)
    {
        GameManager.coin += coin;
    }
    public static int Coin
    {
        get => coin;
        set => coin = value;
    }
}
