using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class BornEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] posBorn;

    [SerializeField] private GameObject[] pre_Enemy;

    private GameObject pre_Select;

    private void randomSelectedEnemy()
    {
        pre_Select = pre_Enemy[Random.Range(0, pre_Enemy.Length)];
    }
}
