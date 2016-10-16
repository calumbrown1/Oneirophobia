using UnityEngine;
using System.Collections;

public class EndzoneScript : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            EndLevel();
        }
    }

    void EndLevel()
    {
        //Could probably go to the end of the scene with this command.
        Debug.Log("thifdsjf;dskjf;ldsjfd;salkj");
    }
}
