using UnityEngine;
using System.Collections;

public class Armor :Item {
	protected int defence;
	public Armor (int armorID, string armorName, int defence):base(armorID,armorName)
	{
		this.defence = defence;
	}
	int Defence {
		get {
			return this.defence;
		}
		set {
			defence = value;
		}
	}

	public override string ToString ()
	{
		return string.Format ("[Armor: ItemID = {0}, Name = {1}, Defence={2}]", itemID, name, Defence);
	}
	
}
