using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelController : MonoBehaviour
{
    public int loadLevel;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Cookie")
        {
            SceneManager.LoadScene(loadLevel);
        }
    }
}
