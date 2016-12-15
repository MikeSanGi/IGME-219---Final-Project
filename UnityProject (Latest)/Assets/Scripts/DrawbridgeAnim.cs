using UnityEngine;
using System.Collections;

public class DrawbridgeAnim : MonoBehaviour 
{
	bool up = false;
	void OnMouseDown()
	{
		up = !up;
			if(!up)
			{
				gameObject.GetComponent<Animation>()["Take 001"].speed = 1.0f; 
				gameObject.GetComponent<Animation> ().Play ("Take 001");
				Debug.Log ("Drawbridge Clicked");
			}
			else if(up)
			{
				gameObject.GetComponent<Animation>()["Take 001"].speed = - 1.0f;
				gameObject.GetComponent<Animation> ().Play ("Take 001");
				Debug.Log ("Drawbridge Clicked");
			}
	}
}
