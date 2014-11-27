using UnityEngine;
using System.Collections;

public class Weapon{
	private int weaponID;
	private string weapon_name;
	private int damage;
	private float attack_speed;
	// Use this for initialization

	public Weapon (int weaponID, string weapon_name, int damage, float attack_speed)
	{
		this.weaponID = weaponID;
		this.weapon_name = weapon_name;
		this.damage = damage;
		this.attack_speed = attack_speed;
	}

	int WeaponID {
		get {
			return this.weaponID;
		}
	}

	string Weapon_name {
		get {
			return this.weapon_name;
		}
	}

	int Damage {
		get {
			return this.damage;
		}
	}

	float Attack_speed {
		get {
			return this.attack_speed;
		}
	}
}
