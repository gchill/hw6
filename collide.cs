using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collide : MonoBehaviour {

	public int lives;
	public Text livetxt;
	public GameObject player;
	public Text gameovertext;

      void Start(){
		lives = 3;
		livetxt.text = "lives = " + lives;
		gameovertext.gameObject.SetActive(false);
	}
	
	void txtChange(){
		lives = lives - 1;
		if(lives == 0){
			Destroy(player);
			gameovertext.gameObject.SetActive(true);
		}
		livetxt.text = "lives = " +lives;
	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "reward"){
			Destroy(collision.gameObject);
		}
		if(collision.gameObject.tag == "enemy"){
			txtChange();
		}
	}
	
}
