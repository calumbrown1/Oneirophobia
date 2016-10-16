using UnityEngine;
using System.Collections;

public class GaintMovementScript : MonoBehaviour
{
    //Giant walking speed.
    public float walkingSpeed;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Move forward.
        transform.position += transform.forward * Time.deltaTime * walkingSpeed;
	}
}
