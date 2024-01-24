using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Move : Hero
{
    [SerializeField] private Transform targetPosition;
    [SerializeField] private LayerMask layerMask;
    private Transform targetMove;
    private bool checkE;
    private GameObject enemy;
    
    void Update()
    {
        checkE = checkRight()!=null;
        move();
        attack();
    }

    private void attack()
    {
        enemy = checkRight();
        if (checkE)
        {
           // enemy.GetComponent<Hero>().Heart(enemy.GetComponent<Hero>().Heart - this.Dame);
        }
        else
        {
            
        }
    }
    private void move()
    {
        if (checkE)
        {
            targetMove = transform;
        }
        else
        {
            targetMove = targetPosition;
        }
        this.transform.position = Vector3.MoveTowards(this.transform.position, targetMove.position, this.Speed * Time.fixedDeltaTime);
    }

    private GameObject checkRight()
    {
        Debug.DrawLine(this.transform.position,this.transform.position + this.Tamdanh * getDirectionMove(),Color.red);
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, getDirectionMove(), this.Tamdanh, layerMask);
        return hit.collider.gameObject;
    }

    private Vector3 getDirectionMove()
    {
        return (targetPosition.position - transform.position).normalized;
    }
}
