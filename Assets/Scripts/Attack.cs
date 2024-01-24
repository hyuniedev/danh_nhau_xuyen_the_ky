using System;
using DefaultNamespace;
using UnityEngine;
public class Attack : Hero
{
    private bool checkE;
    private void Update()
    {
        checkE = Move.getCheckE();
        if (checkE)
        {
                
        }
        else
        {
                
        }
    }
    private GameObject findEnemy()
    {
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, getDirectionMove(), this.Tamdanh, layerMask);
        return hit.collider == null;
    }
    
}
