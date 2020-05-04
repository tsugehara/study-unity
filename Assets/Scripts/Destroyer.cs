using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
	public GameObject masterObj;

	public GameObject firePrefab;

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
		GameObject g = Instantiate(
			firePrefab,
			gameObject.transform.position,
			firePrefab.transform.rotation
		);
		Destroy(g, 3.0f);

		masterObj.GetComponent<GameMaster>().boxNum--;
		Destroy(gameObject);
	}
}
