using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Transform posHoiSinh;
    [SerializeField] private GameObject ParentPlayer;
    [SerializeField] private GameObject Pre_Player;
    public void HoiSinh()
    {
        if (QueueHeroDied.getNumPlayerDied() > 0)
        {
            Player tmp = QueueHeroDied.getPlayerDied();
            tmp.changeState(new StateMove());
            tmp.transform.position = posHoiSinh.position;
        }
        else
        {
            Instantiate(Pre_Player, posHoiSinh.position, this.posHoiSinh.rotation, ParentPlayer.transform);
        }
    }
}
