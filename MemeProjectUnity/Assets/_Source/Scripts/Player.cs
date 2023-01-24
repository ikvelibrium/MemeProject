using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _hp;
    public static int HP;
    void Start()
    {
        HP = _hp;
    }

    
    void Update()
    {
        
    }


}
