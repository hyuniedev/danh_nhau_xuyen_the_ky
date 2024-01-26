using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Move : Hero
{
    [SerializeField] private Transform targetPosition;
    [SerializeField] private LayerMask layerMask;
    private Transform targetMove;
    private GameObject targetEnemy;
    private float timeMakeDame = 0;
    
    void Update()
    {
        checkRight();
        move();
        attack();
        checkSong();
    }

    private void attack()
    {
        if (targetEnemy!=null)
        {
            if (timeMakeDame < this.SpeedMakeDame)
            {
                timeMakeDame += Time.fixedDeltaTime * 1.2f;
            }
            else
            {
                timeMakeDame = 0;
                targetEnemy.GetComponent<Hero>().Heart -= this.Dame;
            }
        }
    }

    private void checkSong()
    {
        if (this.Heart <= 0)
        {
            if (this.tag.Equals("Enemy"))
            {
                Player.Coin += this.Gia;
            }
            Destroy(this.gameObject);
        }
    }
    private void move()
    {
        if (targetEnemy!=null)
        {
            targetMove = transform;
        }
        else
        {
            targetMove = targetPosition;
        }
        this.transform.position = Vector3.MoveTowards(this.transform.position, targetMove.position, this.Speed * Time.fixedDeltaTime);
    }

    private void checkRight()
    {
        Debug.DrawLine(this.transform.position,transform.position + this.Tamdanh * getDirectionMove(),Color.red);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, getDirectionMove(), this.Tamdanh, layerMask);
        targetEnemy = hit.collider != null ? hit.collider.gameObject : null;
    }

    private Vector3 getDirectionMove()
    {
        return (targetPosition.position - transform.position).normalized;
    }
}
