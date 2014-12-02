using UnityEngine;
using System.Collections;
public enum Gender{
	Male,Female
}
public class Player : MonoBehaviour {
	public int m_health;
	public int m_mana;
	public int minDamage;
	public int maxDamage;
	public float m_damage_speed;
	public Weapon m_weapon;
	public Armor m_armor;
	public string m_name;
	public string m_race;
	public int m_defence;
	public Gender m_gender;


	Enemy m_enemy;
	GameHelper m_ghelper;
	// Use this for initialization
	void Start () {
		m_name = "Kaiyang";
		m_health = 100;
		m_mana = 100;
		minDamage = 1;
		maxDamage = 2;
		m_enemy = GameObject.FindGameObjectWithTag ("Enemy").GetComponent<Enemy> ();
		m_weapon = new Weapon (1, "Wood blade", 3,6,1.0f);
		m_armor = new Armor (1, "Wood armor", 3);
		m_damage_speed = m_weapon.Attack_speed;
		m_gender = Gender.Male;
		m_ghelper = GameHelper.Instance;
		m_ghelper.ShowWeapon (m_weapon);
		m_ghelper.ShowArmor (m_armor);
		m_ghelper.ShowHealth (m_health);
	}
	
	// Update is called once per frame
	void Update () {
		m_damage_speed -= Time.deltaTime;
		if(m_damage_speed > 0)
			return;
		m_damage_speed = 1;
		m_enemy.OnDamage (PhysicalAttack());
	}

	private int PhysicalAttack(){
		return (int) Random.Range (minDamage + m_weapon.MinDamage, maxDamage + m_weapon.MaxDamage);
	}

	public void OnDamage(int damage){
		GameHelper.Instance.AddLog ("Goblin deal with " + damage + " damage to " + m_name + "\n");
		m_health -= damage;
		if(m_health < 0)
		{
			Debug.Log("Player is dead");
		}
	}


}
