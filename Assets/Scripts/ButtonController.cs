using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject HeroMove;
    [SerializeField] private Transform DiemHoiSinh;
    [SerializeField] private Transform parentHero;
    public void MakeNewHero()
    {
        if (Player.Coin >= HeroMove.GetComponent<Hero>().Gia)
        {
            // Debug.Log("Coin : "+Player.Coin);
            // Debug.Log("Gia : " +  HeroMove.GetComponent<Hero>().Gia);
            Instantiate(HeroMove, DiemHoiSinh.position, this.transform.rotation, parentHero);
            Player.Coin -= HeroMove.GetComponent<Hero>().Gia;
        }
    }
}
