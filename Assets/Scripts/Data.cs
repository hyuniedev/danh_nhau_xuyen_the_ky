using System;
using System.Collections.Generic;
public class Data
{
    // Heart - Speed Move - Speed Attack - Range Attack - Dame - Coin
    
    // Warrior
    private static List<List<float>> dataWarrior = new List<List<float>>
    {
        // level 1
        new List<float> { 100, 2, 5, 1, 4, 5 },
        // level 2
        new List<float> { 110, 2, 4.5f, 1, 4.5f, 8 },
        // level 3
        new List<float> { 115, 2.2f, 4.2f, 1, 5, 10 },
    };
    // Archer
    private static List<List<float>> dataArcher = new List<List<float>>
    {
        // level 1
        new List<float> { 50, 1.5f, 4, 2.5f, 10, 7 },
        // level 2
        new List<float> { 52, 1.5f, 3.7f, 2.5f, 11, 10 },
        // level 3
        new List<float> { 55, 2, 3.2f, 2.5f, 12, 15 },
    };
    // Boss
    private static List<List<float>> dataBoss = new List<List<float>>
    {
        // level 1
        new List<float> { 250, 2, 6, 1.2f, 20, 15 },
        // level 2
        new List<float> { 255, 2, 5.5f, 1.2f, 21, 18 },
        // level 3
        new List<float> { 55, 2.3f, 5, 1.2f, 22, 20 },
    };
    
    // Tower
    // Heart - Speed Attack - Range Attack - Dame
    private static List<List<float>> dataTower = new List<List<float>>
    {
        new List<float> { 1000, 3, 6, 40 },
        new List<float> { 1200, 2.5f, 6, 45 },
        new List<float> { 1500, 2, 5.5f, 50 }
    };

    public static void LoadData_Hero(Player player, String typeHero)
    {
        List<List<float>> data_player;
        if (player.ViTri == EHero.Warrior)
        {
            data_player = dataWarrior;
        }else if (player.ViTri == EHero.Archer)
        {
            data_player = dataArcher;
        }
        else
        {
            data_player = dataBoss;
        }

        int level = getLevel("Hero", typeHero);
        
        player.Heart = data_player[level][0];
        player.SpeedMove = data_player[level][1];
        player.SpeedAttack = data_player[level][2];
        player.RangeAttack = data_player[level][3];
        player.Dame = data_player[level][4];
        player.Gia = (int)data_player[level][5];
    }

    private static int getLevel(String obj, String type)
    {
        if (obj.Equals("Hero"))
        {
            if (type.Equals("Hero"))
            {
                return GameManager.level_Hero;
            }
            else if(type.Equals("Enemy"))
            {
                return GameManager.level_Enemy;
            }    
        }
        else
        {
            if (type.Equals("Hero"))
            {
                return GameManager.level_Tower_Hero;
            }
            else if(type.Equals("Enemy"))
            {
                return GameManager.level_Tower_Enemy;
            }
        }
        return 0;
    }
    public static void LoadData_Tower(Tower tower, String typeTower)
    {
        int level = getLevel("Tower", typeTower);
        tower.Heart = dataTower[level][0];
        tower.SpeedMove = 0;
        tower.SpeedAttack = dataTower[level][1];
        tower.RangeAttack = dataTower[level][2];
        tower.Dame = dataTower[level][3];
    }
}