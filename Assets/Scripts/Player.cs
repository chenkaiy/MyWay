using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int m_health;
	public int m_mana;
	public int m_attack;
	public float m_attack_speed;
	Enemy m_enemy;
	// Use this for initialization
	void Start () {
		m_health = 100;
		m_mana = 100;
		m_attack = 5;
		m_attack_speed = 1.0f;
		m_enemy = GameObject.FindGameObjectWithTag ("Enemy").GetComponent<Enemy> ();
	}
	
	// Update is called once per frame
	void Update () {
		m_attack_speed -= Time.deltaTime;
		if(m_attack_speed > 0)
			return;
		m_attack_speed = 1;
		m_enemy.OnDamage (m_attack);
	}

	public void OnDamage(int damage){
		GameHelper.Instance.AddLog ("Enemy deal with " + damage + " damage to Player" + "\n");
		m_health -= damage;
		if(m_health < 0)
		{
			Destroy(this.gameObject);
			Debug.Log("Player is dead");
		}
	}


}
