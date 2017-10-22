
using UnityEngine;

public class car : MonoBehaviour {

    public Rigidbody2D rb;

    float speed = 1f;

    // [Optional] for setting the random speed range
    // public float minSpeed = 3f;
    // public float maxSpeed = 7f;

    void Start()
    {
        // speed = Random.Range(minSpeed, maxSpeed);       
    }

    // FixedUpdate is meant for physics, Update is meant for everything else.
    void FixedUpdate () {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
		
	}
}
