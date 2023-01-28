using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] public NavMeshAgent Agent;
    [SerializeField] private GameObject _player;
    [SerializeField] private Animation attackAnim;
    [SerializeField] private float _agrDistance;
    private float _distanceToPlayer;

    
    void Update()
    {
        _distanceToPlayer = Vector3.Distance(_player.transform.position, transform.position);
        if (_distanceToPlayer < _agrDistance)
        {
            Agent.enabled = true;
            Agent.SetDestination(_player.transform.position);
        } 
        if (_distanceToPlayer > _agrDistance)
        {
            Agent.enabled = false;
        }   
    }
    
}
