using UnityEngine;
using System.Collections;

public class Armor : MonoBehaviour {
	private int armorID;
	private string armor_name;
	private int defence;
	public Armor (int armorID, string armor_name, int defence)
	{
		this.armorID = armorID;
		this.armor_name = armor_name;
		this.defence = defence;
	}
	int ArmorID {
		get {
			return this.armorID;
		}
	}

	string Armor_name {
		get {
			return this.armor_name;
		}
	}

	int Defence {
		get {
			return this.defence;
		}
	}
}
