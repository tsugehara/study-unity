using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabeOut : MonoBehaviour
{
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
		Debug.LogWarning("KabeOut!");
		GameMaster gameMaster = GameObject.Find("Master").GetComponent<GameMaster>();
		gameMaster.GameOver(gameMaster.boxNum + "個残してGameOver");
	}
}
