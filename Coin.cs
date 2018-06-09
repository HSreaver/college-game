using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Coin : MonoBehaviour {

	private LevelManager theLevelManager;
	public Text countText;
	public Text winText;
	public int count;

	// Use this for initialization
	void Start () {

		theLevelManager = FindObjectOfType<LevelManager> ();
		count = 0;
		winText.text = " ";
		SetCountText ();
		SetCountText ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			Destroy (gameObject);
			count = count + 1;
			SetCountText ();
		}
		
	}

	public void SetCountText ()
	{
		countText.text = "Coins " + count.ToString ();

		if (count >= 20)
			winText.text = "You win!";
		}

}
