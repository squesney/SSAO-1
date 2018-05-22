﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
	private Animator anim;

	public Image mana_bar;

	public Image HP_bar;

	public float maxmana = 100;

	public float maxHP = 100;

	public float mana;

	public float armor;

	public float _basearmor;

	public float HP;
	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();
		HP = maxHP;
		_basearmor = armor;
		mana = maxmana;
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		if (HP <= 0)
		{
			anim.SetBool("death", true);
			Destroy(gameObject, 3);
			return;
		}
		if (mana < maxmana)
		{
			mana += 5 * Time.deltaTime;
		}

		if (HP >= 100f)
		{
			HP = 100f;
		}
		
		HP_bar.fillAmount = HP / maxHP;
		mana_bar.fillAmount = mana / maxmana;
	}

	
}
