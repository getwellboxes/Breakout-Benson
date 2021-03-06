﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBootsPickup : MonoBehaviour {

    public GameObject Player;
    private RocketBoots boots;
    public Light lights;


    // Use this for initialization
    void Start()
    {
        boots = Player.GetComponent<RocketBoots>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //checks the tag of the collider to see if it's the player.
        if (other.tag == "Player")
        {
            //give the player the powerup and destroy the pickup
            boots.HighJump();
            Destroy(lights);
            Destroy(gameObject);
        }
    }
}
