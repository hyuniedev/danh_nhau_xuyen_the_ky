using UnityEngine;

public class C_Hero : MonoBehaviour
{
    private int level;
    private float heart;
    private float speedMove;
    private float speedAttack;
    private float rangeAttack;
    private float dame;
    [SerializeField] private EHero viTri;
    private int gia;

    public float RangeAttack
    {
        get => rangeAttack;
        set => rangeAttack = value;
    }
    public int Level
    {
        get => level;
        set => level = value;
    }
    public int Gia
    {
        get => gia;
        set => gia = value;
    }

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

    public EHero ViTri => viTri;
}