using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private float heart = 100;
    [SerializeField] private float dame;
    [SerializeField] private float speedAttack;
    [SerializeField] private float radius = 5;
    [SerializeField] private LayerMask _layerMask;
    private GameObject targetEnemy;
    private float timer = 0;

    private void Start()
    {
        timer = speedAttack;
        targetEnemy = null;
    }

    private void Update()
    {
        checkEnemy();
        if (targetEnemy != null)
        {
            Attack();
        }
    }

    private void Attack()
    {
        if (timer < speedAttack)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            targetEnemy.GetComponent<Player>().Heart -= this.dame;
        }
    }
    public float Heart
    {
        get => heart;
        set => heart = value;
    }
    private void checkEnemy()
    {
        Collider2D[] enemys = Physics2D.OverlapCircleAll(transform.position, radius, _layerMask);
        if (targetEnemy == null && enemys.Length > 0)
        {
            Debug.Log("MAMA");
            targetEnemy = enemys[0].gameObject;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,this.radius);
    }
}
