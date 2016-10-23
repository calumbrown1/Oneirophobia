using UnityEngine;
using System.Collections;

public class TriggerAreaScript : MonoBehaviour
{
    //List of all wall scripts which are affected by this trigger.
    public ClosingWallScript[] TriggeredScripts;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void TriggerAllWalls()
    {
        foreach (ClosingWallScript c in TriggeredScripts)
        {
            c.Trigger();
        }
    }
}
