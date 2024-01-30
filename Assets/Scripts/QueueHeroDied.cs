using System.Collections.Generic;

public class QueueHeroDied
{
    private static List<Player> dsPlayerDied = new List<Player>();
    private static List<Player> dsEnemyDied = new List<Player>();

    public static int getNumPlayerDied()
    {
        return dsPlayerDied.Count;
    }

    public static int getNumEnemyDied()
    {
        return dsEnemyDied.Count;
    }

    public static void addPlayerDied(Player player)
    {
        dsPlayerDied.Add(player);
    }

    public static void addEnemyDied(Player player)
    {
        dsEnemyDied.Add(player);
    }

    public static Player getPlayerDied()
    {
        if (dsPlayerDied.Count > 0)
        {
            Player tmp = dsPlayerDied[0];
            dsPlayerDied.RemoveAt(0);
            return tmp;
        }
        else
        {
            return null;
        }
    }

    public static Player getEnemyDied()
    {
        if (dsEnemyDied.Count > 0)
        {
            Player tmp = dsEnemyDied[0];
            dsEnemyDied.RemoveAt(0);
            return tmp;
        }
        else
        {
            return null;
        }
    }
}