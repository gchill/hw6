using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {
	public GameObject PlayerController;
	private bool Pause;
	void Start () {
		Pause = false;
		PlayerController = GameObject.Find("Player Controller");
	}
	
	
	void Update () {
		if(Input.GetButtonDown("pause")){
			
		}
	}
}
