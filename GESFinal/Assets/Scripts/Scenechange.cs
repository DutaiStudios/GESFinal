using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Scenechange : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    public void Begin()
    {
        SceneManager.LoadScene("Level1");
    }

    public void close()
    {
        Application.Quit();
    }
}
