using UnityEngine;
using System.Collections;

public class Getkey : MonoBehaviour {
	public Transform key; 
	public Transform text1; 
	public Transform invisible;

	void OnTriggerEnter ( Collider player ){
		Destroy (key.gameObject ); 
		Destroy (text1.gameObject ); 
		Destroy (invisible.gameObject ); 
		Destroy (gameObject );
	}
}
