using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс отвечающий за общие достижения игрока в игре: накопленные деньги, уровень и трофеи.
/// </summary>
public class Bar : MonoBehaviour
{
    private int level = 0;
    private int money = 0;

    public int GetLevel()
    {
        return level;
    }
    public void SetLevel(int _lvl)
    {
        level = _lvl;
    }
    public int GetMoney()
    {
        return money;
    }
    public void SetMoney(int _money)
    {
        money = _money;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
