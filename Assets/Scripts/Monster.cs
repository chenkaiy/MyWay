using UnityEngine;
using System.Collections;

public class Monster{
	private string name;
	private int damage;
	private int defence;
	private float attack_speed;
	public Monster (string name, int damage, int defence, float attack_speed)
	{
		this.name = name;
		this.damage = damage;
		this.defence = defence;
		this.attack_speed = attack_speed;
	}
	public string Name {
		get {
			return this.name;
		}
	}

	public int Damage {
		get {
			return this.damage;
		}
	}

	int Defence {
		get {
			return this.defence;
		}
	}

	float Attack_speed {
		get {
			return this.attack_speed;
		}
	}
}
