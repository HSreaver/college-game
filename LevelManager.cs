using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	public float waitToRespawn;
	public SimplePlatformController thePlayer;
	public Text countText;
	public Text winText;
	public int count;



	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<SimplePlatformController> ();
		count = 0;
		winText.text = " ";
	}




	// Update is called once per frame
	void Update () {
	}
		


	}



