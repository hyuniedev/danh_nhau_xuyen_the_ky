using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class BornEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] posBorn;
    [SerializeField] private GameObject[] pre_Enemy;
    [SerializeField] private Transform parent_Enemy;
    private float timeBorn = 2;

    private void Start()
    {
        InvokeRepeating(nameof(Born),3.0f,timeBorn);
    }

    private void Born()
    {
        timeBorn = Random.Range(3, 10);
        Invoke(nameof(InstanRandomPosition),0);
    }

    private GameObject randomSelectedEnemy()
    {
        return pre_Enemy[Random.Range(0, pre_Enemy.Length)];
    }

    private Transform randomTransformBornEnemy()
    {
        return posBorn[Random.Range(0, posBorn.Length)];
    }

    private void InstanRandomPosition()
    {
        Instantiate(randomSelectedEnemy(), randomTransformBornEnemy().position, transform.rotation, parent_Enemy);
    }
}
