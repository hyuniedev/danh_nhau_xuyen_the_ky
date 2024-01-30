using System;                                
using UnityEngine;
using UnityEngine.UI;

public enum eHero
{
    Top,
    Ad,
    Monster
}
public class Player : C_Hero
{
    [SerializeField] private eHero ViTri;
    [SerializeField] private LayerMask _layerMaskOfEnemy;
    private float tamDanh;
    [Header("Mục tiêu")] [SerializeField] private Transform posTower;
    private Transform target;
    private Vector2 direc;
    private C_Hero Enemy;
    private float timer;
    private IState currentState;
    private void Start()
    {
        direc = _layerMaskOfEnemy.Equals("Player") ? Vector2.right : Vector2.left;
        target = posTower;
        if (ViTri == eHero.Top) tamDanh = 2;
        else if (ViTri == eHero.Ad) tamDanh = 5;
        else if (ViTri == eHero.Monster) tamDanh = 7;
        changeState(new StateMove());
    }

    private void Update()
    {
        if (currentState != null)
        {
            currentState.OnExecute(this);
        }
    }

    public void changeState(IState newState)
    {
        if (currentState != null)
        {
            currentState.OnExit(this);
        }

        currentState = newState;
        if (currentState != null)
        {
            currentState.OnEnter(this);
        }
    }

    public void DiChuyen()
    {
        transform.position =
            Vector3.MoveTowards(transform.position, target.position, this.SpeedMove * Time.fixedDeltaTime);
        if (checkEnemy())
        {
            changeState(new StateAttack());
        }
    }

    public void DungDiChuyen()
    {
        target = Enemy.transform;
    }
    public void TanCong()
    {
        if (timer < this.SpeedAttack)
        {
            timer += Time.fixedDeltaTime;
        }
        else
        {
            timer = 0;
            Enemy.Heart -= this.Dame;
        }

        if (!checkEnemy())
        {
            changeState(new StateMove());
        }
    }

    public void DungTanCong()
    {
        timer = 0;
    }

    public void Chet()
    {
        
    }

    private bool checkEnemy()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direc, this.tamDanh, _layerMaskOfEnemy);
        if (hit.collider != null)
        {
            Enemy = hit.collider.gameObject.GetComponent<C_Hero>();
        }
        else
        {
            Enemy = null;
        }
        return hit.collider != null;
    }
}