using UnityEngine;
using System.Collections;

public class GiantSpawnerScript : MonoBehaviour
{
    //This represents the gaint's height.  The giant's spawn at the positions of their heads, which is currently 28 units up.
    public float GiantSpawnHeight;

    //The giant prefab model to instantiate.
    public GameObject GiantModel;

    //A float, in seconds, of how frequently giants are spawned.
    public float GiantSpawnTime;

    //The min and max X locations for the giant's to spawn.  Should be between -24 and 24.
    public float LowerXSpawnBound;
    public float HigherXSpawnBound;

    // Use this for initialization
    void Start ()
    {
        //Spawn an endless horde of giants every some seconds.
        InvokeRepeating("SpawnGiant", GiantSpawnTime, GiantSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //This script will spawn giants.  Gaints spawn at the Z position of the spawner, Y 28, and a random X. 
    //A gaint should spawn every 5 seconds.
    void SpawnGiant()
    {
        float randomX;
        randomX = Random.Range(LowerXSpawnBound, HigherXSpawnBound);
        Vector3 spawnPoint = new Vector3(randomX, GiantSpawnHeight, transform.position.z);

        Instantiate(GiantModel, spawnPoint, Quaternion.identity);
    }
}
