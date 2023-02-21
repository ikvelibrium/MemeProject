using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskTrecker : MonoBehaviour
{
    [SerializeField] private GameObject TaskTreckerPanel;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private int _questNumber = 0;
    [SerializeField] private List<string> _AdditionalPhrases = new List<string>();
    [SerializeField] Diolog diolog;
    [SerializeField] QTE _qte;
    private int _ColectedBeer;
    
    private void Update()
    {
        
        switch (_questNumber)
        {
            
            case 0:
                _text.text = $"Поговори с темой";
                if (diolog.Counter >= 1)
                {
                    _questNumber++;
                }
                
                break;
            case 1:
                _text.text = $"Собранное пиво {_ColectedBeer} из 7";
                if (_ColectedBeer >= 7)
                {

                    _questNumber++;
                    diolog.ChangePhrases();
                }

                break;
            case 2:
                _text.text = $"Наебашь холодильнику";
                if (_qte.FridgeGotKicked == true)
                {
                    _questNumber++;
                    diolog.ChangePhrases();
                }
                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            
        }

    }
    public void BeerColected()
    {
        if (_ColectedBeer < 7)
        {
            _ColectedBeer++;
        } else if (_ColectedBeer > 7)
        {
           
            _ColectedBeer++;
            _questNumber++;
            diolog.ChangePhrases();
        }
        
    }
    
}
