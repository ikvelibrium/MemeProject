using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float _hp;
    [SerializeField] private Slider _hpSlider;
    [SerializeField] private float _reloadTime;
    [SerializeField] private GameObject _bulletPref;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] TaskTrecker taskTrecker;


    private float _actualReloadTime;
   
    
    
    

    void Start()
    {
        _actualReloadTime = _reloadTime;
    }

    
    void Update()
    {
        _hpSlider.value = _hp;
        _reloadTime -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            Shoot();
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
    public void GetDamage(float damage)
    {
        _hp -= damage;
        if (_hp <= 0)
        {
            Die();
        }
    }
    public void Heal(float heal)
    {
        _hp += heal;
        taskTrecker.BeerColected();
    }
    void Die()
    {

    }
    public void Shoot() 
    {
        Instantiate(_bulletPref, _shootPoint.position, _shootPoint.rotation); 
        
    }
}
