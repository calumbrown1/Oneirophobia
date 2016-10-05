using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuControllerScript : MonoBehaviour {

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
}
