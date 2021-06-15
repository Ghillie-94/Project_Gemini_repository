using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScrollRate : MonoBehaviour
{
    public float cameraScrollRate;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(cameraScrollRate*Time.deltaTime,0,0);
    }
}
