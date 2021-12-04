using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public BoxCollider Boxcollider;
    public GameObject mesh;

    private void OnTriggerEnter(Collider other)
    {
        ScoreScript.scoreValue += 10;
        Destroy(mesh);
    }



}
