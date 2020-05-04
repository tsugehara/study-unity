using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		// nothing
	}

	// Update is called once per frame
	void Update()
	{
		float speed = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) ? 0.2f : 0.1f;
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += transform.forward * speed;
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position -= transform.forward * speed;
		}
	}
}
