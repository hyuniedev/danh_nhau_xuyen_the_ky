using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Transform[] Arr_posHoiSinh;
    [SerializeField] private GameObject ParentPlayer;
    [SerializeField] private GameObject[] Pre_Player;
    public void Instan_Hero(int index)
    {
        int fee = Data.getCoin(index);
        if (GameManager.Coin < fee) return;
        if (GameManager._queueHeroDied.getNumPlayerDied(index) > 0)
        {
            Player tmp = GameManager._queueHeroDied.getPlayerDied(index);
            tmp.changeState(new StateMove());
            tmp.transform.position = posHoiSinh();
            GameManager.Coin -= fee;
        }
        else
        {
            Instantiate(Pre_Player[index], posHoiSinh(), this.transform.rotation, ParentPlayer.transform);
            GameManager.Coin -= fee;
        }
        
    }

    public void IncLevel_Hero()
    {
        GameManager.level_Hero++;
    }

    public void IncLevel_Tower(Tower tower)
    {
        GameManager.level_Tower_Hero++;
        tower.OnUpdateLevel();
    }
    private Vector3 posHoiSinh()
    {
        return new Vector3(Arr_posHoiSinh[0].position.x,Random.Range(Arr_posHoiSinh[0].position.y,Arr_posHoiSinh[1].position.y),0);
    }
}
