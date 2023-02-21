using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.UI;

public class Diolog : MonoBehaviour
{


    [SerializeField] private List<string> _phrases = new List<string>();
    [SerializeField] private GameObject _diologWindow;
    [SerializeField] private TMP_Text _text;
    public int Counter = 0;
    bool kostl = true;
    private bool _isMovingForward = true;
   
    

    private void Update()
    {
        Speak();
        
    }

    private void OnTriggerStay(Collider other)
    {
        if ( other.gameObject.layer == 7)
        {
            
            _diologWindow.SetActive(true);
            kostl = true;
            
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        _diologWindow.SetActive(false);
        kostl = false;
    }
    public void ChangePhrases()
    {
        _isMovingForward = true;
       
    }

    void Speak()
    {
        if (Input.GetKeyDown(KeyCode.X) && _isMovingForward == true)
        {
            Counter++;
            _isMovingForward = false;
        }

        if (kostl == true)
        {
            if (Counter < _phrases.Count)
            {
                _text.text = _phrases[Counter];

            }
            if (Counter > _phrases.Count)
            {
                _diologWindow.SetActive(false);
                Counter = _phrases.Count - 1;
                _isMovingForward = false;
            }
            
        }
    }


}