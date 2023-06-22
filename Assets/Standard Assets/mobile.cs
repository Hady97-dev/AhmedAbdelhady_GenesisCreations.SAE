using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobile : MonoBehaviour {

	// Use this for initialization

	public float moveSpeed = 15f;
	public float CountUp=0f ;

	



	 public void Right()
	{
		
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
	}

	public void Left()
	{
		 

			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}

		void FixedUpdate()
	{
		CountUp += (Time.deltaTime);
		if (CountUp >= 5.0f) {

			moveSpeed = (moveSpeed + 0.001f);

		}

		}
}
