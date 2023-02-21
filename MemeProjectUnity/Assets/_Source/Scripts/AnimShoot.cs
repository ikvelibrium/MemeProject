using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimShoot : MonoBehaviour
{
    [SerializeField] public Player player;

    
    public void CallShoot()
    {
        player.Shoot();
    }
}
