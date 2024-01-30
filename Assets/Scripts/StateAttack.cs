public class StateAttack : IState
{
    public void OnEnter(Player player)
    {
        player.DungDiChuyen();
    }

    public void OnExecute(Player player)
    {
        player.TanCong();
        if (player.Heart <= 0)
        {
            player.changeState(new StateDeath());
        }
    }

    public void OnExit(Player player)
    {
        player.DungTanCong();
    }
}