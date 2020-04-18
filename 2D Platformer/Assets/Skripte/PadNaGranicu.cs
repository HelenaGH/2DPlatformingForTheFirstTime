using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadNaGranicu : MonoBehaviour 
{
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
