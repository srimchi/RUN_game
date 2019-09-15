using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f; 
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        // add forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // move right 
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")) 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
