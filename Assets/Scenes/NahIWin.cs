using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NahIWin : MonoBehaviour
{
    [SerializeField] private int SceneBuild;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "NahIWin")
        {
            SceneManager.LoadScene(SceneBuild, LoadSceneMode.Single);
        }


    }
}
