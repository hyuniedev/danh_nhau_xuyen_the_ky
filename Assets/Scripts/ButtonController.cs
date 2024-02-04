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
        if (GameManager._queueHeroDied.getNumPlayerDied(index) > 0)
        {
            Player tmp = GameManager._queueHeroDied.getPlayerDied(index);
            tmp.changeState(new StateMove());
            tmp.transform.position = posHoiSinh.position;
        }
        else
        {
            Instantiate(Pre_Player[index], posHoiSinh.position, this.posHoiSinh.rotation, ParentPlayer.transform);
        }
    }
}
