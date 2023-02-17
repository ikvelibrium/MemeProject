using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aclohol : MonoBehaviour
{
    [SerializeField] private AlcholSO  _alcSO;
    [SerializeField] private GameObject PressButtonUI;
    [SerializeField]  Player player;

    private bool _kostl = false;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _kostl = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        PressButtonUI.SetActive(true);
        if ( other.gameObject.layer == 7 && _kostl == true)
        {
            PressButtonUI.SetActive(false);
            // Player.HP += _alcSO.amountOfHealing;

            player.Heal(_alcSO.amountOfHealing);
            _kostl = false;
            Destroy(gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PressButtonUI.SetActive(false);
    }
}
