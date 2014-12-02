using UnityEngine;
using System.Collections;

public class Armor {
	private int armorID;
	private string armor_name;
	private int defence;
	public Armor (int armorID, string armor_name, int defence)
	{
		this.armorID = armorID;
		this.armor_name = armor_name;
		this.defence = defence;
	}
	public int ArmorID {
		get {
			return this.armorID;
		}
	}

	public string Armor_name {
		get {
			return this.armor_name;
		}
	}

	public int Defence {
		get {
			return this.defence;
		}
	}

	public override string ToString(){
		return armor_name;
	}
}
