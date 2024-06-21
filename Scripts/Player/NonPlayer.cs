using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class NonPlayer : MonoBehaviour
{
    public SpriteRenderer rd;
    public Sprite Top,Down,Left,Right;
    public Dialogue Dialogue;
    public NonPlayerInfo Info;
    Vector3 target;
    Vector3 Offset = new Vector3(0, -0.5f, 0);
    public GameObject Player;
    public float Distance;
    void Start()
    {
        Invoke("Rotation", 5);
    }

    void Update()
    {
        target = Player.transform.position + Offset;
        Distance = Vector2.Distance(target, gameObject.transform.position);
    }

    public void TalkNonPlayer(NonPlayerInfo Info)
    {
        Dialogue.Talk2(Info);
    }

    public void Rotation()
    {
        int x = Random.Range(0, 4);
        if (x == 0)
        {
            rd.sprite = Top;
        }
        if (x == 1)
        {
            rd.sprite = Down;
        }
        if (x == 2)
        {
            rd.sprite = Right;
        }
        if (x == 3)
        {
            rd.sprite = Left;
        }
        Invoke("Rotation", 5);
    }

    private void OnMouseDown()
    {
        if(Distance < 2)
        {
            Dialogue.Talk2(Info);
        }
    }
}
