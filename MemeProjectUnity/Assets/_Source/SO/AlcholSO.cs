using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AlcholSO", menuName = "ScriptableObjects/AlcholSO", order = 1)]

public class AlcholSO : ScriptableObject
{
   
    [SerializeField] private GameObject _alcPref;

    public int amountOfHealing;
}
