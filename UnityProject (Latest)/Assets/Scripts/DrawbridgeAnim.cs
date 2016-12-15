using UnityEngine;
using System.Collections;

public class DrawbridgeAnim : MonoBehaviour 
{
	bool up = false;
	void Update()
	{
		if (Input.GetMouseButtonDown (0))
		{
			if(!up)
			{
				gameObject.GetComponent<Animation>()["Take 001"].speed = 1.0f; 
				gameObject.GetComponent<Animation> ().Play ("Take 001");
				Debug.Log ("Drawbridge Clicked");
				up = true;
			}
			else if(up)
			{
				gameObject.GetComponent<Animation>()["Take 001"].speed = - 1.0f;
				gameObject.GetComponent<Animation> ().Play ("Take 001");
				Debug.Log ("Drawbridge Clicked");
				up = false;
			}
		}
	}
}
