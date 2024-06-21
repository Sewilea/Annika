using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public int Coin;
    public Text text;
    Inventory inventory;
    public KaishiManager KaiMan;
    public GameObject Chicken, Cow, Sheep, Content_Animals;

    void Start()
    {
        inventory = GetComponent<Inventory>();
    }

    void Update()
    {
        text.text = Coin.ToString();
    }

    public void BuyItem(Item item)
    {
        if(Coin >= item.BuyCoin)
        {
            inventory.AddIteminSlots(item, 1);
            Coin = Coin - item.BuyCoin;
        }
    }

    public void SellItem()
    {
        Item item = inventory.Mouse.item;

        if(item.ID != 0 && item.SellCoin != 0)
        {
            Coin = Coin + (item.SellCoin * inventory.Mouse.Amount);
            inventory.Mouse.item = inventory.Empty;
            inventory.Mouse.Amount = 0;
        }

    }

    public void BuyChicken()
    {
        if(Content_Animals.transform.childCount < 10 && Coin - 100 >= 0)
        {
            int x = Random.Range(KaiMan.AnimalKai[0].Xstart, KaiMan.AnimalKai[0].Xfinish);
            int y = Random.Range(KaiMan.AnimalKai[0].Ystart, KaiMan.AnimalKai[0].Yfinish);
            Coin = Coin - 100;
            GameObject Obje = Instantiate(Chicken,new Vector2(x,y),Quaternion.identity, Content_Animals.transform);
            Obje.name = "Chicken";

        }
    }
    public void BuyCow()
    {
        if (Content_Animals.transform.childCount < 10 && Coin - 100 >= 0)
        {
            int x = Random.Range(KaiMan.AnimalKai[0].Xstart, KaiMan.AnimalKai[0].Xfinish);
            int y = Random.Range(KaiMan.AnimalKai[0].Ystart, KaiMan.AnimalKai[0].Yfinish);
            Coin = Coin - 100;
            GameObject Obje = Instantiate(Cow, new Vector2(x, y), Quaternion.identity, Content_Animals.transform);
            Obje.name = "Cow";

        }
    }

    public void BuySheep()
    {
        if (Content_Animals.transform.childCount < 10 && Coin - 100 >= 0)
        {
            int x = Random.Range(KaiMan.AnimalKai[0].Xstart, KaiMan.AnimalKai[0].Xfinish);
            int y = Random.Range(KaiMan.AnimalKai[0].Ystart, KaiMan.AnimalKai[0].Yfinish);
            Coin = Coin - 100;
            GameObject Obje = Instantiate(Sheep, new Vector2(x, y), Quaternion.identity, Content_Animals.transform);
            Obje.name = "Sheep";

        }
    }
}
