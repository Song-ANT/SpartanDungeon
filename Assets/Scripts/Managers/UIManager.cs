using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public List<UIItem> inventory;

    #region Properties
    [field : SerializeField] public UIMain UIMain {  get; private set; }
    [field : SerializeField] public UIStatus UIStatus {  get; private set; }
    [field : SerializeField] public UIInventory UIInventory {  get; private set; }
    #endregion

    #region Init
    private void Awake()
    {
        Instance = this;
    }
    #endregion
}
