using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Transform posHoiSinh;
    [SerializeField] private GameObject ParentPlayer;
    [SerializeField] private GameObject[] Pre_Player;
    public void Instan_Hero(int index)
    {
        int fee = 0;
        if (index == 0) fee = 5;
        else if (index == 1) fee = 7;
        else if (index == 2) fee = 15;
        if (GameManager.Coin < fee) return;
        if (GameManager._queueHeroDied.getNumPlayerDied(index) > 0)
        {
            Player tmp = GameManager._queueHeroDied.getPlayerDied(index);
            tmp.changeState(new StateMove());
            tmp.transform.position = posHoiSinh.position;
            GameManager.Coin -= fee;
        }
        else
        {
            Instantiate(Pre_Player[index], posHoiSinh.position, this.posHoiSinh.rotation, ParentPlayer.transform);
            GameManager.Coin -= fee;
        }
    }
}
