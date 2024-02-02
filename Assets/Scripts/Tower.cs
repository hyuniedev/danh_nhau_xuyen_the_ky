using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Tower : MonoBehaviour
{
    [SerializeField] private float heart = 100;
    [SerializeField] private float dame;
    [SerializeField] private float speedAttack;
    [SerializeField] private float radius = 5;
    [SerializeField] private LayerMask _layerMask;
    private GameObject targetEnemy;
    private float timer = 0;
    private Collider2D[] dsEnemy;

    private void Start()
    {
        timer = speedAttack;
        targetEnemy = null;
    }

    private void Update()
    {
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
        if (timer < speedAttack)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            targetEnemy.GetComponent<Player>().Heart -= Random.Range(this.dame-5,this.dame+5);
            if (targetEnemy.GetComponent<Player>().Heart <= 0)
            {
                targetEnemy = null;
            }
        }
    }
    public float Heart
    {
        get => heart;
        set => heart = value;
    }
    private Collider2D[] checkEnemy()
    {
        return Physics2D.OverlapCircleAll(transform.position, radius, _layerMask);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,this.radius);
    }
}
