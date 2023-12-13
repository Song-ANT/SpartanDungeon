using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [field: SerializeField] public Character Player { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        SetItem();

        UIManager.Instance.UIMain.SetData(Player.characterSO);
        UIManager.Instance.UIStatus.SetStatus(Player.characterSO);
    }

    private void SetItem()
    {
        Player.AddItem(new Item("Axe", atk: 10, def: 5, hp: 0, crt:0));
        Player.AddItem(new Item("Bow", atk: 10, def: 0, hp: 0, crt: 5));
        Player.AddItem(new Item("DoubleAxe", atk: 15, def: 0, hp: 0, crt: 0));
        Player.AddItem(new Item("Hammer", atk: 5, def: 10, hp: 0, crt: 0));
        Player.AddItem(new Item("Sword", atk: 5, def: 0, hp: 5, crt: 5));
    }

}
