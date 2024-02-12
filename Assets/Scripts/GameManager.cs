using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Slider slideCoin;
    [SerializeField] private float maxTime;
    [SerializeField] private Text txtCoin;
    [Header("Born Enemy")]
    [SerializeField] private Transform[] E_Arr_posHoiSinh;
    [SerializeField] private GameObject E_ParentEnemy;
    [SerializeField] private GameObject[] Pre_Enemy;
    private float timer;
    private static int coin;
    public static QueueHeroDied _queueHeroDied = new QueueHeroDied();

    private void Start()
    {
        timer = 0;
        slideCoin.maxValue = maxTime;
        coin = 0;
    }

    private void Update()
    {
        IncCoinPerTime();
        txtCoin.text = "Coin : " + coin;
    }

    private void BornEnemySystem()
    {
        
    }
    private void IncCoinPerTime()
    {
        if (timer <= maxTime)
        {
            timer += Time.deltaTime;
            slideCoin.value = timer;
        }
        else
        {
            timer = 0;
            IncCoin(5);
        }
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
