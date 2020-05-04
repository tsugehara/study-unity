using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDataFetcher : MonoBehaviour
{
	public Text resultMessageText;

	// Start is called before the first frame update
	void Start()
	{
		if (string.IsNullOrEmpty(DataSender.resultMessage))
		{
			resultMessageText.text = "結果がありません";
		}
		else
		{
			resultMessageText.text = DataSender.resultMessage;
		}
	}

	// Update is called once per frame
	void Update()
	{
		// nothing
	}
}
