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
    
    void Update()
    {
        checkE = checkRight();
        if (checkE)
        {
            targetMove = targetPosition;
        }
        else
        {
            targetMove = transform;
        }
        this.transform.position = Vector3.MoveTowards(this.transform.position, targetMove.position, this.Speed * Time.fixedDeltaTime);
    }

    private bool checkRight()
    {
        Debug.DrawLine(this.transform.position,this.transform.position + this.Tamdanh * getDirectionMove(),Color.red);
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, getDirectionMove(), this.Tamdanh, layerMask);
        return hit.collider == null;
    }

    private Vector3 getDirectionMove()
    {
        return (targetPosition.position - transform.position).normalized;
    }
}
