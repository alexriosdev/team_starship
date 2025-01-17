﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDamage : MonoBehaviour {

    public float damage = 25.0f;
	
	// Update is called once per frame
	void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.tag == "Enemy")
        {
            //print("Laser hit a: " + collision.gameObject.name);
            collision.gameObject.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }		
	}
}
