using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public string m_name;
	public int m_health;
	public int m_mana;
	public int m_damage;
	public float m_damage_speed;
	public int m_defence;
	Player m_player;
	// Use this for initialization
	void Start () {
		m_health = 200;
		m_mana = 100;
		m_damage = 3;
		m_damage_speed = 1.5f;
		m_player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		m_damage_speed -= Time.deltaTime;
		if (m_damage_speed > 0)
			return;
		m_damage_speed = 1.5f;
		m_player.OnDamage(m_damage);

	}

	public void OnDamage(int damage){
		GameHelper.Instance.AddLog ("Player deal with " + damage + " damage to Enemy" + "\n");
		m_health -= damage;
		if (m_health < 0) {
			EnemyGenerator(1);
			Debug.Log("Enemy is dead");
		}
	}

	public void EnemyGenerator(int level){
		switch (level) {
			case 1:
			m_health = Random.Range(100,300);
			m_mana = Random.Range(100,200);
			m_damage = Random.Range(1,5);
			m_damage_speed = Random.Range(1,2);
			break;
		}
	}

}
