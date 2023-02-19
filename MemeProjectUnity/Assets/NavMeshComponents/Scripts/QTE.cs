using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class QTE : MonoBehaviour
{
    [SerializeField] GameObject _QTEPanel;
    [SerializeField] private float _time;
    [SerializeField] private Text _text; 
    [SerializeField] private Slider _pressedTimesSlider;
    [SerializeField] private float _timesNeededTopres;
    private float _timesPressed = 0;
    private float _actualTimeLeft;
    private bool _inAction = false;
    private void Start()
    {
        _actualTimeLeft = _time;
        _text.text = "Press F to win";
        _timesNeededTopres = 0;
    }
    void Update()
    {

        _pressedTimesSlider.value = _timesNeededTopres;
        if (Input.GetKeyDown(KeyCode.F))
        {
            _timesNeededTopres++;
        }
        
        if (_actualTimeLeft < 0)
        {
            _text.text = "Lol you failed";
            _QTEPanel.SetActive(false);
            _text.text = "Press F to win";
            _timesNeededTopres = 0;
            _actualTimeLeft = _time;
        }
        if (_inAction == true && _timesNeededTopres > 0)
        {
            _actualTimeLeft -= Time.deltaTime;
        }
        if (_timesNeededTopres <= 10)
        {
            _text.text = "Win";
            _QTEPanel.SetActive(false);
            _text.text = "Press F to win";
            _timesPressed = 0;
            _actualTimeLeft = _time;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("dsasdasd");
        _QTEPanel.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        _QTEPanel.SetActive(false);
    }
}
