using System.Collections.Generic;

public class QueueHeroDied
{
    private static List<List<Player>> dsPlayerDied = new List<List<Player>>();
    private static List<List<Player>> dsEnemyDied = new List<List<Player>>();

    public QueueHeroDied()
    {
        dsPlayerDied.Add(new List<Player>());
        dsPlayerDied.Add(new List<Player>());
        dsPlayerDied.Add(new List<Player>());
        
        dsEnemyDied.Add(new List<Player>());
        dsEnemyDied.Add(new List<Player>());
        dsEnemyDied.Add(new List<Player>());
        
    }
    public int getNumPlayerDied(int indexEHero)
    {
        if (indexEHero == 0)
        {
            return dsPlayerDied[0].Count;
        }else if (indexEHero == 1)
        {
            return dsPlayerDied[1].Count;
        }
        else
        {
            return dsPlayerDied[2].Count;
        }
    }

    public int getNumEnemyDied(int indexEHero)
    {
        if (indexEHero == 0)
        {
            return dsEnemyDied[0].Count;
        }else if (indexEHero == 1)
        {
            return dsEnemyDied[1].Count;
        }
        else
        {
            return dsEnemyDied[2].Count;
        }
    }

    public void addPlayerDied(Player player)
    {
        if (player.ViTri == EHero.Warrior)
        {
            dsPlayerDied[0].Add(player);
        }else if (player.ViTri == EHero.Archer)
        {
            dsPlayerDied[1].Add(player);
        }else if (player.ViTri == EHero.Boss)
        {
            dsPlayerDied[2].Add(player);
        }
    }

    public void addEnemyDied(Player player)
    {
        GameManager.IncCoin(player.Gia);
        if (player.ViTri == EHero.Warrior)
        {
            dsEnemyDied[0].Add(player);
        }else if (player.ViTri == EHero.Archer)
        {
            dsEnemyDied[1].Add(player);
        }else if (player.ViTri == EHero.Boss)
        {
            dsEnemyDied[2].Add(player);
        }
    }

    public Player getPlayerDied(int indexEHero)
    {
        if (dsPlayerDied[indexEHero].Count > 0)
        {
            Player tmp = dsPlayerDied[indexEHero][0];
            dsPlayerDied[indexEHero].RemoveAt(0);
            Data.LoadData_Hero(tmp,"Hero");
            return tmp;
        }
        else
        {
            return null;
        }
    }

    public Player getEnemyDied(int indexEHero)
    {
        if (dsEnemyDied[indexEHero].Count > 0)
        {
            Player tmp = dsEnemyDied[indexEHero][0];
            dsEnemyDied[indexEHero].RemoveAt(0);
            Data.LoadData_Hero(tmp,"Enemy");
            return tmp;
        }
        else
        {
            return null;
        }
    }
}