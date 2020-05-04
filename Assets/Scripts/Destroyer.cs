using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
	public GameObject masterObj;

	// Start is called before the first frame update
	void Start()
	{
		// nothing
	}

	// Update is called once per frame
	void Update()
	{
		// nothing
	}

	private void OnCollisionEnter(Collision collision)
	{
		masterObj.GetComponent<GameMaster>().boxNum--;
		Destroy(gameObject);
	}
}
