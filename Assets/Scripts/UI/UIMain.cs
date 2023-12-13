using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{
    #region Field
    [SerializeField] private TextMeshProUGUI _txtName;
    [SerializeField] private TextMeshProUGUI _txtLevel;

    [SerializeField] private TextMeshProUGUI _txtExp;
    [SerializeField] private Slider _sliderExp;

    [SerializeField] private GameObject _buttons;
    [SerializeField] private Button _btnStatus;
    [SerializeField] private Button _btnInventory;
    #endregion

    #region Init
    private void Start()
    {
        _btnInventory.onClick.AddListener(OpenInventory);
        _btnStatus.onClick.AddListener(OpenStatus);
    }
    #endregion

    #region Character
    public void SetData(CharacterSO characterSO)
    {
        _txtName.text = characterSO.name;
        _txtLevel.text = characterSO.level.ToString();
        
        _txtExp.text = $"{characterSO.exp} / 12";
        _sliderExp.value = characterSO.exp / 12f;


    }
    #endregion


    #region Buttons
    private void OpenStatus()
    {
        _buttons.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
    }

    private void OpenInventory()
    {
        _buttons.SetActive(false );
        UIManager.Instance.UIInventory.gameObject.SetActive(true);
    }

    public void OpenMain()
    {
        _buttons.SetActive(true);
        UIManager.Instance.UIStatus.gameObject.SetActive(false);
        UIManager.Instance.UIInventory.gameObject.SetActive(false);
    }
    #endregion

}
