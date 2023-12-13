using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ChracterData",
    menuName = "SpartanDungeon/Data/Character", order = 0)]

public class CharacterSO : ScriptableObject
{
    [Header("Character Info")]
    public string name;
    public int level;
    public int exp;
    

    [Header("Status Info")]
    public int atk;
    public int def;
    public int hp;
    public int crt;
}
