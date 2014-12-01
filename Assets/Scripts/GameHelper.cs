using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour {
	private static GameHelper GHinstance;
	public RectTransform rt;
	public Scrollbar sb;
	public Text combatLog;
	public Text playerName;
	public Text damageTex;
	public Text raceTex;
	public Text defenceTex;
	public Text genderTex;
	public Text dpsTex;
	public Text weapon_nameTex;
	public Text armor_nameTex;
	public Text healthTex;
	void Awake() {
		GHinstance = this;
	}
	// Use this for initialization

	public static GameHelper Instance
	{
		get { return GHinstance; }
	}

	void Start () {
		combatLog.text = " ";
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void AddLog (string Log) {
		combatLog.text = combatLog.text + Log;
		Debug.Log (combatLog.preferredHeight);
		if(combatLog.preferredHeight > 200)
		{
			rt.sizeDelta = new Vector2 (rt.rect.height, combatLog.preferredHeight);
			sb.value = 0;
		}
	}	

	public void ShowName(string name){
		playerName.text = name;
	}

	public void ShowRace(string name){
		raceTex.text = name;
	}

	public void ShowDamage(int damage){
		damageTex.text = "Damage: " + damage;
	}

	public void ShowDefence(int defence){
		defenceTex.text = "Defence: " + defence;
	}

	public void ShowDps(float Dps){
		dpsTex.text = "DPS: " + Dps;
	}

	public void ShowGender(string gender){
		genderTex.text = gender;
	}

	public void ShowWeapon(Weapon weapon){
		weapon_nameTex.text = weapon.Weapon_name;
	}

	public void ShowArmor(Armor armor){
		armor_nameTex.text = armor.Armor_name;
	}

	public void ShowHealth(int health){
		healthTex.text = "Health: " + health;
	}
}
