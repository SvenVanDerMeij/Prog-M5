using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static event Action death;
    [SerializeField] GameObject player;
   
    private void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.name == "player")
        {
            death?.Invoke();
            Destroy(gameObject);
        }
    }
    void Update()
    {
        
    }
}
