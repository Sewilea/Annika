using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public bool Timer;
    public float timer;
    public int X, Y, Z, W;

    public GameObject DialoguePanel, CloseButton, DialogueImage, CloseImage;
    public bool DialogueBool;
    public Text Dialoguetext, DialogueImagetext;
    public Image image;
    public char[] letters;

    public NonPlayerInfo Annika, Erica, Sophie;

    void Start()
    {
        Talk2(Annika.texts[0],Annika);
    }

    void Update()
    {
        if (Timer)
        {
            timer += 1 * Time.deltaTime;
        }
    }

    public void TalkAnnika()
    {
        Y++;

        if(Y > Annika.texts2.Length - 1)
        {
            Y = 0;
        }

        Talk2(Annika.texts2[Y],Annika);
    }

    public void TalkErica()
    {
        Talk2(Erica.texts2[Z], Erica);

        Z++;

        if (Z > Erica.texts2.Length - 1)
        {
            Z = 0;
        }
    }

    public void TalkSophie()
    {
        Talk2(Sophie.texts2[W], Sophie);

        W++;

        if (W > Sophie.texts2.Length - 1)
        {
            W = 0;
        }

        
    }

    public void Talk(string a)
    {
        X = 0;
        Dialoguetext.text = "";
        CloseButton.SetActive(false);
        letters = a.ToCharArray();
        DialoguePanel.SetActive(true);
        DialogueBool = true;
        Invoke("Write", 0.07f);
    }

    public void Write()
    {
        if (X < letters.Length)
        {
            Dialoguetext.text += letters[X].ToString();
            X++;
            Invoke("Write", 0.07f);
        }
        else
        {
            CloseButton.SetActive(true);
        }
    }

    public void Talk2(NonPlayerInfo Info)
    {
        X = 0;
        DialogueImagetext.text = "";
        CloseImage.SetActive(false);
        image.sprite = Info.sprite;
        letters = Info.texts[Random.Range(0,Info.texts.Length)].ToCharArray();
        DialogueImage.SetActive(true);
        DialogueBool = true;
        Invoke("Write2", 0.07f);
    }

    public void Talk2(string a, NonPlayerInfo Info)
    {
        X = 0;
        DialogueImagetext.text = "";
        CloseImage.SetActive(false);
        image.sprite = Info.sprite;
        letters = a.ToCharArray();
        DialogueImage.SetActive(true);
        DialogueBool = true;
        Invoke("Write2", 0.07f);
    }

    public void Write2()
    {
        if (X < letters.Length)
        {
            DialogueImagetext.text += letters[X].ToString();
            X++;
            Invoke("Write2", 0.07f);
        }
        else
        {
            CloseImage.SetActive(true);
        }
    }
}
