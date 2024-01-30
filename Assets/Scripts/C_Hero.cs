using UnityEngine;

public class C_Hero : MonoBehaviour
{
    [Header("Thuộc tính")]
    [SerializeField] private float heart;
    [SerializeField] private float speedMove;
    [SerializeField] private float speedAttack;
    [SerializeField] private float dame;

    public float Heart
    {
        get => heart;
        set => heart = value;
    }

    public float SpeedMove
    {
        get => speedMove;
        set => speedMove = value;
    }

    public float SpeedAttack
    {
        get => speedAttack;
        set => speedAttack = value;
    }

    public float Dame
    {
        get => dame;
        set => dame = value;
    }
}