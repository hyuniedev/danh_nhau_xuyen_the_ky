public class StateMove : IState
{
    public void OnEnter(Player player)
    {
        player.DungTanCong();
    }

    public void OnExecute(Player player)
    {
        player.DiChuyen();
    }

    public void OnExit(Player player)
    {
        player.DungDiChuyen();
    }
}