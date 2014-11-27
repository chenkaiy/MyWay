﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public int m_health;
	public int m_mana;
	public int m_attack;
	public float m_attack_speed;
	Player m_player;
	// Use this for initialization
	void Start () {
		m_health = 200;
		m_mana = 100;
		m_attack = 3;
		m_attack_speed = 1.5f;
		m_player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		m_attack_speed -= Time.deltaTime;
		if (m_attack_speed > 0)
			return;
		m_attack_speed = 1.5f;
		m_player.OnDamage(m_attack);

	}

	public void OnDamage(int damage){
		GameHelper.Instance.AddLog ("Player deal with " + damage + " damage to Enemy" + "\n");
		m_health -= damage;
		if (m_health < 0) {
			Destroy (this.gameObject);
			Debug.Log("Enemy is dead");
		}
	}

}
