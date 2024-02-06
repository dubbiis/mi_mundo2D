using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private float speedMultiplier = 0.001f;
    public Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition += (direction * (speed*speedMultiplier));
    }
}