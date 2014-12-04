using UnityEngine;
using System.Collections;

public class Item {
	protected int itemID;
	protected string name;
	// Use this for initialization
	public Item (int itemID, string name)
	{
		this.itemID = itemID;
		this.name = name;
	}
	public int ItemID {
		get {
			return this.itemID;
		}
		set {
			itemID = value;
		}
	}

	public string Name {
		get {
			return this.name;
		}
		set {
			name = value;
		}
	}

	public override string ToString ()
	{
		return string.Format ("[Item: ]");
	}
}
