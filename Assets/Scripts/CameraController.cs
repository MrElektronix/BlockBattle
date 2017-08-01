using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    private Transform _object;



    // Use this for initialization
	private void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		transform.LookAt(_object);
	}
}
