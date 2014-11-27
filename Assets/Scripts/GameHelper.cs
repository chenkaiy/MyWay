using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour {
	private static GameHelper GHinstance;

	public Text CombatLog;
	void Awake() {
		GHinstance = this;
	}
	// Use this for initialization

	public static GameHelper Instance
	{
		get { return GHinstance; }
	}

	void Start () {
		CombatLog.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddLog (string Log) {
		CombatLog.text = CombatLog.text + Log;
	}
}
