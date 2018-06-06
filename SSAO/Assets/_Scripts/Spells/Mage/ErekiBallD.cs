﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ErekiBallD : NetworkBehaviour
{
	private float cost = 5f;
	private float damage = 10;
	
	void Awake ()
	{
		GetComponentInParent<PSNetwork>().mana -= cost;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("enemy"))
		{
			other.GetComponent<enemyMovement>().HP -= damage;
		}
		if (other.CompareTag("Player"))
		{
			other.GetComponent<PSNetwork>().HP -= (damage - (damage * other.GetComponent<PlayerStatus>().armor / 100));
		}
		Destroy(gameObject);
	}
}
