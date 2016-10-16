﻿using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    /// <summary>
    /// Trigger collision handler.
    /// You tend to wake up before a death event in a dream, so the death event should be triggered just before.  Large trigger zones can simulate this.
    /// </summary>
    /// <param name="col">The colliding trigger's collider component.</param>
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "DeathTrigger")
        {
            Death();
        }
    }

    /// <summary>
    /// This kills the player.
    /// When one of the defeat conditions is met, this method is triggered.
    /// </summary>
    public void Death()
    {
        print("Player has died.");
    }
}
