using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float _hp;
    [SerializeField] private Slider _hpSlider;
    public static float HP;
    

    void Start()
    {
        HP = _hp;
    }

    
    void Update()
    {
        _hpSlider.value = HP;
    }


}
