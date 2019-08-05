using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play : MonoBehaviour {
	
	public float speed;
	public Text countTxt;
	public Text winTxt;

	private Rigidbody rb;
	private int count;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winTxt.text = "";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce(movement * speed);
	}
	void OnTriggerEnter( Collider  other){
		if (other.gameObject.CompareTag("Pick Up")){
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();
		}
	}

	void SetCountText(){
		countTxt.text = "Count" + count.ToString();
		if (count >=10){
			winTxt.text = " You Win! ";
		}
	}
}
