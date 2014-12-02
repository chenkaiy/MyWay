using UnityEngine;
using System.Collections;

public class Weapon{
	private int weaponID;
	private string weapon_name;
	private int minDamage;
	private int maxDamage;
	private float attack_speed;
	// Use this for initialization

	public Weapon (int weaponID, string weapon_name, int minDamage, int maxDamage, float attack_speed)
	{
		this.weaponID = weaponID;
		this.weapon_name = weapon_name;
		this.minDamage = minDamage;
		this.maxDamage = maxDamage;
		this.attack_speed = attack_speed;
	}

	public int WeaponID {
		get {
			return this.weaponID;
		}
		set {
			weaponID = value;
		}
	}

	public string Weapon_name {
		get {
			return this.weapon_name;
		}
		set {
			weapon_name = value;
		}
	}

	public int MinDamage {
		get {
			return this.minDamage;
		}
		set {
			minDamage = value;
		}
	}

	public int MaxDamage {
		get {
			return this.maxDamage;
		}
		set {
			maxDamage = value;
		}
	}

	public float Attack_speed {
		get {
			return this.attack_speed;
		}
		set {
			attack_speed = value;
		}
	}

	public override string ToString ()
	{
		return weapon_name;
	}

	public int Damage(){
		return (int) Random.Range (minDamage, maxDamage);
	}
}
