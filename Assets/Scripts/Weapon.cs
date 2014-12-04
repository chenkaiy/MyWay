using UnityEngine;
using System.Collections;

public class Weapon : Item{
	protected int minDamage;
	protected int maxDamage;
	protected float attack_speed;
	// Use this for initialization

	public Weapon (int itemID, string weaponName,int minDamage, int maxDamage, float attack_speed):base(itemID,weaponName)
	{
		this.minDamage = minDamage;
		this.maxDamage = maxDamage;
		this.attack_speed = attack_speed;
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

	public int Damage(){
		return (int) Random.Range (minDamage, maxDamage);
	}

	public override string ToString ()
	{
		return string.Format ("[Weapon: ItemID = {0}, Name = {1}, minDamage={2}, maxDamage={3}, attack_speed={4}]", itemID, name, minDamage, maxDamage, attack_speed);
	}
	
}
