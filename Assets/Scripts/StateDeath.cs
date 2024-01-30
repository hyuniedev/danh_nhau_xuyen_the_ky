public class StateDeath : IState
{
    public void OnEnter(Player player)
    {
        player.DungDiChuyen();
        player.DungTanCong();
    }

    public void OnExecute(Player player)
    {
        player.Chet();
    }

    public void OnExit(Player player)
    {
        player.HoiSinh();
    }
}