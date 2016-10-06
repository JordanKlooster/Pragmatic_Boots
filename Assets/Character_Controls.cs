using UnityEngine;
using System.Collections;

public class Character_Controls : MonoBehaviour {

    //This is Pragmatic Boots

    Rigidbody2D rb;

    public float MaxRunSpeed = 2;
    public float MaxForce;
    public float FMagnitude = 20;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	
	void Update () {
        // make AddForce work Using a function based on velocity

        rb.AddForce( new Vector2( Input.GetAxisRaw("Horizontal") * (MaxRunSpeed - Mathf.Abs(rb.velocity.x) ) , 0) * Time.deltaTime * FMagnitude);
        

    }
}
