    using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QTE : MonoBehaviour
{
    [SerializeField] GameObject _QTEPanel;
    [SerializeField] private float _time;
    [SerializeField] private Text _text; 
    [SerializeField] private Slider _pressedTimesSlider;
    [SerializeField] private float _howMuchTimesToPress;
    [SerializeField] private TMP_Text _tmpText;
    private float _timesPressed = 0;
    private float _actualTimeLeft;
    private bool _inAction = false;
    public bool FridgeGotKicked = false;
    private void Start()
    {
        _actualTimeLeft = _time;
        _text.text = "Press F to win";
        _timesPressed = 0;
        _pressedTimesSlider.maxValue = _howMuchTimesToPress;
    }
    void Update()
    {
        _tmpText.text = $"Осталось {_actualTimeLeft} секунд";
        Debug.Log(_timesPressed);
        _pressedTimesSlider.value = _timesPressed;
        if (Input.GetKeyDown(KeyCode.F))
        {
            _timesPressed++;
        }
        
        if (_actualTimeLeft < 0)
        {
            _text.text = "Lol you failed";
            _QTEPanel.SetActive(false);
            _text.text = "Press F to win";
            _timesPressed = 0;
            _actualTimeLeft = _time;
        }
        if (_inAction == true && _timesPressed > 0)
        {
            _actualTimeLeft -= Time.deltaTime;
        }
        if (_timesPressed >= _howMuchTimesToPress)
        {
            _text.text = "Win";
            
            
            _actualTimeLeft = 3;
            _tmpText.gameObject.SetActive(false);
            FridgeGotKicked = true;
            if (_actualTimeLeft < 0)
            {
                _QTEPanel.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("dsasdasd");
        _QTEPanel.SetActive(true);
        _inAction = true;
    }
    private void OnTriggerExit(Collider other)
    {
        _QTEPanel.SetActive(false);
    }
}
