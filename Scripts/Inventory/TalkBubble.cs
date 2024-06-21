using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkBubble : MonoBehaviour
{
    public bool isTalk;
    public GameObject Doyoueat, Doyousleep, Doyouteleport;
    public float TeleportFloat;
    Inventory inventory;
    public KaishiManager manager;
    Player player;
    public GameObject Player;
    public Clock clock;
    void Start()
    {
        inventory = GetComponent<Inventory>();
        player = inventory.PlayerScript;
    }

    void Update()
    {
        
    }

    public void Doyoueatyes()
    {
        inventory.DecreaseIteminSlot(inventory.ChooseSlot);
        player.healt += 20;
        Doyoueat.SetActive(false);
        isTalk = false;
    }

    public void Doyoueatno()
    {
        Doyoueat.SetActive(false);
        isTalk = false;
    }

    public void Doyousleepyes()
    {
        clock.Day++;
        clock.Hour = 6;
        clock.Minute = 0;
        player.healt = 100;
        clock.DayPassed();
        Invoke("AfterDay", 1);
        Doyousleep.SetActive(false);
        isTalk = false;
    }

    public void Doyousleepno()
    {
        Doyousleep.SetActive(false);
        Doyouteleport.SetActive(false);
        isTalk = false;
    }

    void AfterDay()
    {
        Player.transform.position = new Vector2(0, 19);
        inventory.FarmGrow();
        manager.ReCaveCreate();
        inventory.PlantGrow();
        manager.AnimalProduct();
    }

    public void StartofTeleport()
    {
        clock.DayPassed();
        Invoke("Teleport", 1);
    }

    public void Teleport()
    {
        if(TeleportFloat == 1)
        {
            Player.transform.position = new Vector2(-26, 85);
        }
        if (TeleportFloat == 2)
        {
            Player.transform.position = new Vector2(-30, 20);
        }
        if (TeleportFloat == 3)
        {

        }
        if (TeleportFloat == 4)
        {

        }
        Doyouteleport.SetActive(false);
        isTalk = false;
    }

}
