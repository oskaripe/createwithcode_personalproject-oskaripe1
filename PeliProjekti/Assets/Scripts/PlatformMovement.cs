using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public GameObject PlatformObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move platform up
        PlatformObject.transform.Translate(new Vector3(0.0f, 1.0f, 0.0f), Space.World);

        //move platform down
        PlatformObject.transform.Translate(new Vector3(0.0f, -1.0f, 0.0f), Space.World);
    }

 
}
