using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            restartLevel();
        }
    }
     private void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
