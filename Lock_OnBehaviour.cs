using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock_OnBehaviour : MonoBehaviour
{
	public GameObject[] Candidates = new GameObject[50];
	public int candid_num;
	float[] Candidates_dist = new float[50];
	float min_dist;

	GameObject target;

    // Start is called before the first frame update
    void Start()
    {
		target = null;
		min_dist = 1000;
		candid_num = -1;
    }

	public GameObject LockTarget()
	{
		if (candid_num == -1)
		{
			return null;
		}
		else
		{
			for (int i = 0; i <= candid_num; i++)
			{
				Candidates_dist[i] = Vector3.Distance(Candidates[i].transform.position, transform.position);
				if (Candidates_dist[i] < min_dist)
				{
					min_dist = Candidates_dist[i];
					target = Candidates[i];
				}
				Candidates[i] = null;
			}
			candid_num = -1;
			min_dist = 1000;
			return target;
		}		
	}
}
