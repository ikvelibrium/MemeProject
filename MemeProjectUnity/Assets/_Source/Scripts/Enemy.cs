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
    [SerializeField] private Animator _anim;
    [SerializeField] private float _dealDamage;
    [SerializeField] private float _hp;
    [SerializeField] private float _timeBetweenAttacks;
    [SerializeField]  Player player;
    private float _actualReloadTIme;
    private float _distanceToPlayer;
    private bool _isAttacking = false;

    private void Start()
    {
        _actualReloadTIme = _timeBetweenAttacks;
    }

    void Update()
    {
        _actualReloadTIme -= Time.deltaTime;
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
        if (_isAttacking == true && +_actualReloadTIme <= 0)
        {
             player.GetDamage(_dealDamage);
            _actualReloadTIme = _timeBetweenAttacks;
        }
    }
    public void GetDamage(float damage)
    {
        Debug.Log("Enemy get damaged");
        _hp -= damage;
        if (_hp <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            _anim.SetBool("IsAttacking", true);
            _isAttacking = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            _anim.SetBool("IsAttacking", false);
            _isAttacking = false;
        }
    }
}
