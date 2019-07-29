using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс отвечающий за общие достижения игрока в игре: накопленные деньги, уровень и трофеи.
/// </summary>
public class Bar : MonoBehaviour
{
    //Счетчик уровня
    private int level = 0;
    public int GetLevel()
    {
        return level;
    }
    public void SetLevel(int _lvl)
    {
        level = _lvl;
    }

    //Счетчик денег
    private int money = 0;
    public int GetMoney()
    {
        return money;
    }
    public void SetMoney(int _money)
    {
        money = _money;
    }
    
    //Счетчик трофеев
    private List<GameObject> trophy = new List<GameObject>();
    public void AddTrophy(GameObject _trophy)
    {
        trophy.Add(_trophy);
    }
}
