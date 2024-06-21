using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemWarn : MonoBehaviour
{
    public GameObject Prefabtext;
    public GameObject Content;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Warn(Item item, int amount)
    {
        GameObject text = Instantiate(Prefabtext, Content.transform);
        text.transform.GetChild(0).GetComponent<Text>().text = "+" + amount;
        text.transform.GetChild(1).GetComponent<Image>().sprite = item.sprite;
        Destroy(text, 2f);
    }
}
