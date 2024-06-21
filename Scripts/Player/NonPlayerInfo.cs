using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "npc", menuName = "npc")]
public class NonPlayerInfo : ScriptableObject
{
    public string Name;
    public Sprite sprite;
    public string[] texts, texts2;
}
