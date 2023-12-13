using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Character : MonoBehaviour
{
    #region Field
    public CharacterSO characterSO;

    public List<Item> inventory { get; private set; } = new List<Item>();
    #endregion



    public void AddItem(Item item)
    {
        inventory.Add(item);
    }

    public void Equip(Item item)
    {
        item.isEquiped = true;
        characterSO.atk += item.atk;
        characterSO.def += item.def;
        characterSO.hp += item.hp;
        characterSO.crt += item.crt;
    }

    public void UnEquip(Item item)
    {
        item.isEquiped=false;
        characterSO.atk -= item.atk;
        characterSO.def -= item.def;
        characterSO.hp -= item.hp;
        characterSO.crt -= item.crt;
    }
}
