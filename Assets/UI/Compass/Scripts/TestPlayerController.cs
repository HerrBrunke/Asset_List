using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerController : MonoBehaviour {
	 public GameObject Player;

	// Use this for initialization
	void Start () {
		Player.transform.position = new Vector3(1, 1, 1);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("w"))
		{
			
		}
	}
}
