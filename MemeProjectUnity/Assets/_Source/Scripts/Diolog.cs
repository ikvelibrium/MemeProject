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
    int counter = 0;
    bool kostl = true;
    
    private void Update()
    {
        Speak();
        Debug.Log(counter);
    }

    private void OnTriggerStay(Collider other)
    {
        if ( other.gameObject.layer == 7)
        {
            Debug.Log("asdasdasd");
            _diologWindow.SetActive(true);
            kostl = true;
            
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        _diologWindow.SetActive(false);
        kostl = false;
    }

    void Speak()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            counter++;
        }

        if (kostl == true)
        {
            if (counter < _phrases.Count)
            {
                _text.text = _phrases[counter];
            }
            if (counter > _phrases.Count)
            {
                _diologWindow.SetActive(false);
                counter = _phrases.Count - 1;
            }
            
        }
    }


}