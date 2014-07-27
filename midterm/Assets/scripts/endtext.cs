using UnityEngine;
using System.Collections;

public class endtext : MonoBehaviour {
	public Transform text4;  
	
	void OnTriggerEnter ( Collider player ){
		Destroy (text4.gameObject ); 
	}
}

