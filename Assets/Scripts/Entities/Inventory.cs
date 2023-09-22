using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject slotPrefab;
    public const int numSlots = 5;
    public int currentSlots = 0;
    public Item[] startItems = new Item[numSlots];
    GameObject[] slots = new GameObject[numSlots];

    public void Start()
    {
        CreateSlots();
        SetItem();
    }

    public void CreateSlots()
    {
        if (slotPrefab != null)
        {
            for (int i = 0; i < numSlots; i++)
            {
                GameObject newSlot = Instantiate(slotPrefab);
                newSlot.name = "ItemSlot_" + i;

                newSlot.transform.SetParent(this.gameObject.transform);

                slots[i] = newSlot;
            }
        }
    }

    public void SetItem()
    {
        for (int i = 0; i < startItems.Length; i++)
        {
            if (startItems[i] != null && currentSlots < numSlots)
            {
                slots[currentSlots].transform.GetChild(0).GetComponent<Image>().sprite = startItems[i].item_Sprite;
                currentSlots++;
            }

            if (startItems[i] == null)
            {

            }
        }
    }

}
