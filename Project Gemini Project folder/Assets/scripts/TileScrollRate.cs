using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScrollRate : MonoBehaviour
{
    
   public float scrollRate;
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-scrollRate*Time.deltaTime,0,0);
    }
}
