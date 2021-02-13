using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public CapsuleCollider player;
    float originalHeight;
    public float reducedHeight;

    void Start ()
    {
        originalHeight = player.height;
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
            GetDown();
        else if (Input.GetKeyUp(KeyCode.LeftControl))
            GetUp();
    }

    void GetDown ()
    {
        player.height = reducedHeight;
    }

    void GetUp ()
    {
        player.height = originalHeight;
    }
}
