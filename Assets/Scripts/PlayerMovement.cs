using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private int _speed = 4;

    private Rigidbody _rigibody;
	// Use this for initialization
	private void Start ()
	{
	    _rigibody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	private void Update ()
	{
	    var x = Input.GetAxisRaw("Horizontal") * _speed;
	    var z = Input.GetAxisRaw("Vertical") * _speed;
	    _rigibody.velocity = new Vector3(x, 0, z);
	}
}
