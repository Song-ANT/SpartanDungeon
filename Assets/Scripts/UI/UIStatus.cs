using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    #region Field
    [SerializeField] private TextMeshProUGUI _txtAtk;
    [SerializeField] private TextMeshProUGUI _txtDef;
    [SerializeField] private TextMeshProUGUI _txtHP;
    [SerializeField] private TextMeshProUGUI _txtCrt;

    [SerializeField] private Button _btnStatusBack;
    #endregion


    #region Init
    private void Start()
    {
        _btnStatusBack.onClick.AddListener(OnClickBack);
    }
    private void Update()
    {
        SetStatus(GameManager.instance.Player.characterSO);
    }
    #endregion

    #region Buttons
    private void OnClickBack()
    {
        UIManager.Instance.UIMain.OpenMain();
    }
    #endregion

    #region SetStatus
    public void SetStatus(CharacterSO characterSO)
    {
        _txtAtk.text = characterSO.atk.ToString();
        _txtDef.text = characterSO.def.ToString();
        _txtHP.text = characterSO.hp.ToString();
        _txtCrt.text = characterSO.crt.ToString();
    }
    #endregion
}
