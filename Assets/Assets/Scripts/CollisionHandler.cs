using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject deathEffect;
    private void OnTriggerEnter(Collider other)
    {
        PlayerDeath();
    }
    private void PlayerDeath()
    {
        //Debug.Log("Player is dead");
        //SendMessage("OnPlayerDeath");
        //deathEffect.SetActive(true);
    }
}
