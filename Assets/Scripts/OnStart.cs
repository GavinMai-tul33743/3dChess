using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube); 
        newCube.transform.position = new Vector3(0, 1, -10); // Set cube position
        newCube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f); // Adjust cube size

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
