using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZArea : MonoBehaviour
{
    public float threshold = -50;

    void Update()
    {
        if(transform.position.y < threshold)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
