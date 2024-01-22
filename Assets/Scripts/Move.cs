using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Move : Hero
{
    [SerializeField] private Transform targetPosition;
    [SerializeField] private LayerMask layerMask;
    
    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, targetPosition.position, this.Speed * Time.fixedDeltaTime);
    }

    private bool checkRight()
    {
        Debug.DrawRay(this.transform.position,this.transform.position + this.Tamdanh * Vector3.right,Color.red);
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, Vector2.right, this.Tamdanh, layerMask);
        return hit.collider != null;
    }

    private Vector3 getVectorMove(Transform target)
    {
        return new Vector3(target.position.x - this.transform.position.x,
            target.position.y - this.transform.position.y,
            target.position.z - this.transform.position.z);
    }
}
