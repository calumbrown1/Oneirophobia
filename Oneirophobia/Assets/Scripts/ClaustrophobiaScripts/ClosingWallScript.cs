using UnityEngine;
using System.Collections;

public class ClosingWallScript : MonoBehaviour
{
    //The speed of the walls to close.
    public float Speed;

    //The wall will start to move if this condition is met.
    bool IsWallTriggered;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (IsWallTriggered)
        {
            //Move forwards. 
            transform.position += transform.forward * Time.deltaTime * Speed;
        }
    }

    public void Trigger()
    {
        IsWallTriggered = true;
    }
}
