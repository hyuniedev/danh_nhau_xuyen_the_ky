
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text txtCoin;
    private static int coin;
    public int level_Hero { get; set;}
    public int level_Tower_Hero { get; set; }
    public int level_Enemy { get; set; }
    public int level_Tower_Enemy { get; set; }
    public static GameManager Instance{ get; private set; }
    private void Awake() {
        if(Instance != null && Instance!=this){
            Destroy(this.gameObject);
        }
        else{
            Instance = this;
        }
    }

    private void Start()
    {
        // set begin coin
        coin = 50;
        // set default level
        level_Hero = 0;
        level_Tower_Hero = 0;
        level_Enemy = 0;
        level_Tower_Enemy = 0;
    }

    private void Update()
    {
        this.txtCoin.text = "Coin : " + coin;
    }
    
    public void IncCoin(int coin)
    {
        GameManager.coin += coin;
    }
    public static int Coin
    {
        get => coin;
        set => coin = value;
    }
}
