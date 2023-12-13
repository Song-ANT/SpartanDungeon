using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItem : MonoBehaviour
{
    [SerializeField] private Button _btnItem;
    [SerializeField] private Image _image;
    [SerializeField] private GameObject _equip;

    private Item _item;


    private void Start()
    {
        _btnItem.onClick.AddListener(OnBtnItemClick);
    }
    public void SetItem(Item item)
    {
        _item = item;
        ShowUI();
    }

    private void ShowUI()
    {
        if (_image.sprite == null)
        {
            _image.sprite = Resources.Load<Sprite>("items/" + _item.spriteName);
        }
        _image.gameObject.SetActive(true);

        _equip.SetActive(_item.isEquiped);

    }

    private void OnBtnItemClick()
    {
        if (_item.isEquiped) UnEquip();
        else Equip();
    }

    private void Equip()
    {
        GameManager.instance.Player.Equip(_item);
        ShowUI();
    }

    private void UnEquip()
    {
        GameManager.instance.Player.UnEquip(_item);
        ShowUI();
    }
}
