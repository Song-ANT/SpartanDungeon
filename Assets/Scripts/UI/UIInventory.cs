using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    #region Field
    [SerializeField] private Button _btnInventoryBack;
    [SerializeField] private UIItem _item;

    private int _maxInven = 9;
    private GameObject _itemParent;

    private List<UIItem> _items;
    #endregion

    #region Init
    private void Awake()
    {
        _itemParent = transform.Find("Inventory/InventorySpace").gameObject;
    }
    private void Start()
    {
        _items = UIManager.Instance.inventory;
        _btnInventoryBack.onClick.AddListener(OnClickBack);
        InitInventory();
        SetInventory();
    }
    #endregion


    #region Button
    private void OnClickBack()
    {
        UIManager.Instance.UIMain.OpenMain();
    }
    #endregion

    private void InitInventory()
    {
        _items = new List<UIItem>();

        for(int i=0; i < _maxInven; i++)
        {
            UIItem newItem = Instantiate(_item);
            newItem.transform.parent = _itemParent.transform;

            _items.Add(newItem);
        }
    }

    private void SetInventory()
    {
        List<Item> items = GameManager.instance.Player.inventory;

        for(int i=0; i < items.Count; i++)
        {
            Item item = items[i];
            _items[i].SetItem(item);
        }
    }
}
