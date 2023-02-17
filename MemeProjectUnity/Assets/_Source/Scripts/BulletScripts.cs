using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScripts : MonoBehaviour
{

    [SerializeField] private float _bulletSpeed;
    [SerializeField] private float _dealDamage;
    [SerializeField] private Rigidbody _rb;
    

  
   


    private void Start()
    {

        _rb.AddForce(_rb.transform.forward * _bulletSpeed);
        Destroy(gameObject, 5);
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.layer == 8)
        {
            collision.gameObject.GetComponent<Enemy>().GetDamage(_dealDamage);
        }

        Destroy(gameObject);
    }
}
