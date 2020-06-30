using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock_OnTarget : MonoBehaviour
{
	Lock_OnBehaviour lock_onplayer;
	HitDetection thisobject; 
	bool potential_Target;
	bool lock_on;

	void Start()
	{
		lock_on = false;
		potential_Target = false;
		thisobject = GetComponent<HitDetection>();
		lock_onplayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Lock_OnBehaviour>();
	}

	void Update()
	{
		if (Input.GetButtonDown("Middle Click"))
		{
			if (lock_on == false && potential_Target == true)
			{
				lock_onplayer.candid_num += 1;
				lock_onplayer.Candidates[lock_onplayer.candid_num] = gameObject;
				lock_on = true;
			}	
			else
			{
				lock_on = false;
			}
			
		}
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.name == "Player_View")
		{
			potential_Target = true;
		}
	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.gameObject.name == "Player_View")
		{
			potential_Target = false;
		}
	}
}
