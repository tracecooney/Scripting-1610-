
using UnityEngine;

public class Loops : MonoBehaviour
{
	public string[] Names;

	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < 50; i++)
		{
			print("Word " + i);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
