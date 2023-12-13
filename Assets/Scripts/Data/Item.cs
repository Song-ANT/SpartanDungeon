using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public string name {  get; private set; }
    public string spriteName { get; private set; }

    public int atk {  get; private set; }
    public int def {  get; private set; }
    public int hp {  get; private set; }
    public int crt {  get; private set; }

    public bool isEquiped;

    public Item(string name, int atk, int def, int hp, int crt)
    {
        this.name = name;
        this.spriteName = name;
        this.atk = atk;
        this.def = def;
        this.hp = hp;
        this.crt = crt;

        this.isEquiped = false;
    }
    
    
}
