using UnityEngine;
using System.Collections;

public class GaintSpawnerScript : MonoBehaviour
{
    //This represents the gaint's height.  The giant's spawn at the positions of their heads, which is currently 28 units up.
    public float GiantSpawnHeight;

    //The giant prefab model to instantiate.
    public GameObject GiantModel;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    //This script will spawn giants.  Gaints spawn at the Z position of the spawner, Y 28, and a random X. 
    //A gaint should spawn every 5 seconds.
    void SpawnGiant()
    {
        float randomX;
        randomX = Random.Range(-24, -24);

        Vector3 spawnPoint = new Vector3(randomX, GiantSpawnHeight, transform.position.z);
        Instantiate(GiantModel, spawnPoint, Quaternion.identity);
    }
}
