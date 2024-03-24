using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") ;
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); ;
        }
    }
    public void Restartgame()
    {
        SceneManager.LoadScene(1);
    }
}
