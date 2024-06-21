using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skills : MonoBehaviour
{
    public int Total_xp;
    public int Forage_xp, Mining_xp, Fighting_xp, Farming_xp;

    public Text SkillText;
    
    void Update()
    {
        Total_xp = Forage_xp + Mining_xp + Fighting_xp + Farming_xp;

        SkillText.text = "Total XP : " + Total_xp + "\nForaging XP : " + Forage_xp + "\nFarming XP : " + Farming_xp + "\nMining XP : " + Mining_xp
           + "\nFighting XP : " + Fighting_xp;
    }
}
