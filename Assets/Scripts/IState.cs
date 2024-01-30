public interface IState
{
    void OnEnter(Player player);
    void OnExecute(Player player);
    void OnExit(Player player);
}