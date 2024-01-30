public class StateAttack : IState
{
    public void OnEnter(Player player)
    {
        player.DungDiChuyen();
    }

    public void OnExecute(Player player)
    {
        player.TanCong();
    }

    public void OnExit(Player player)
    {
        player.DungTanCong();
    }
}