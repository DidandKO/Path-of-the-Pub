using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Класс алкогольных напитков
/// </summary>
public class Product : MonoBehaviour
{
    //Состав продукта
    private List<GameObject> consist = new List<GameObject>();
    public void SetConsist(GameObject _ingredient)
    {
        consist.Add(_ingredient);
    }
    public List<GameObject> GetConsist()
    {
        return consist;
        //для высчитывания крепости коктеля
    }

    //Цена продукта зависит от состава
    private int price;
    public int GetPrice()
    {
        return price;
    }

    //Крепость напитка зависит от состава
    private int alcDegree;
    public void SetAlcDegree()
    {
        //Суммирование крепости ингредиентов
    }
}
