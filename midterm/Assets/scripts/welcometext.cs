using UnityEngine;
using System.Collections;

public class welcometext : MonoBehaviour {
	public Transform text3;  
	
	void OnTriggerEnter ( Collider player ){
		Destroy (text3.gameObject ); 
	}
}
