using UnityEngine;
using System.Collections;

public class castletext : MonoBehaviour {
	public Transform text2;  
	
	void OnTriggerEnter ( Collider player ){
		Destroy (text2.gameObject ); 
	}
}
