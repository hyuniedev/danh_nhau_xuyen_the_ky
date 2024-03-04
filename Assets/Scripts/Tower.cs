
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Tower : C_Hero
{
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private Slider _sliderHeart;
    private GameObject targetEnemy;
    private float timer = 0;
    private Collider2D[] dsEnemy;

    private void Start()
    {
        Data.LoadData_Tower(this);
        _sliderHeart.maxValue = Heart;
        timer = SpeedAttack;
        targetEnemy = null;
    }

    private void Update()
    {
        _sliderHeart.value = Heart;
        dsEnemy = checkEnemy();
        if (targetEnemy != null)
        {
            Attack();
        }
        else
        {
            if (dsEnemy.Length > 0)
            {
                targetEnemy = dsEnemy[0].gameObject;
            }
        }
    }

    private void Attack()
    {
        if (timer < SpeedAttack)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            targetEnemy.GetComponent<Player>().Heart -= Random.Range(this.Dame-5,this.Dame+5);
            if (targetEnemy.GetComponent<Player>().Heart <= 0)
            {
                targetEnemy = null;
            }
        }   
    }
    private Collider2D[] checkEnemy()
    {
        return Physics2D.OverlapCircleAll(transform.position, RangeAttack, _layerMask);
    }
}
