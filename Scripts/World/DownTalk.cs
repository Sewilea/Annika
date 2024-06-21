using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownTalk : MonoBehaviour
{
    Dialogue Dialogue;
    TalkBubble Bubble;
    GameObject Player;
    public string Text;
    public bool Sleep, Teleport;
    public float teleportfloat;
    float distance;
    void Start()
    {
        Dialogue = GameObject.Find("Script").GetComponent<Dialogue>();
        Bubble = GameObject.Find("Script").GetComponent<TalkBubble>();
        Player = GameObject.Find("Annika");
    }

    void Update()
    {
        distance = Vector2.Distance(gameObject.transform.position, Player.transform.position);
    }

    private void OnMouseDown()
    {
        if(distance < 1)
        {
            if (Sleep)
            {
                Bubble.Doyousleep.SetActive(true);
                Bubble.isTalk = true;
            }
            if (Teleport)
            {
                Bubble.Doyouteleport.SetActive(true);
                Bubble.TeleportFloat = teleportfloat;
                Bubble.isTalk = true;
            }
            if (!Sleep && !Teleport)
            {
                Dialogue.Talk(Text);
            }
        }
    }
}
