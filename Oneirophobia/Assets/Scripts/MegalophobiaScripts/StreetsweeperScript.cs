using UnityEngine;
using System.Collections;

public class StreetsweeperScript : MonoBehaviour
{
    //The speed of the sweeper.
    public float Speed;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Move forwards. 
        transform.position += transform.forward * Time.deltaTime * Speed;
    }

    /// <summary>
    /// Trigger collision handler.
    /// You tend to wake up before a death event in a dream, so the death event should be triggered just before.  Large trigger zones can simulate this.
    /// </summary>
    /// <param name="col">The colliding trigger's collider component.</param>
    void OnTriggerEnter(Collider col)
    {
        if (col.name.Contains("Giant"))
        {
            Destroy(col.gameObject);
        }
    }
}
