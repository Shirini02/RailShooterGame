using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GoToGameScene", 2.0f);
    }
    //After SpashScene Go to Game Scene
    void GoToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
