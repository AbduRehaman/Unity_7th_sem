using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCreator : MonoBehaviour
{
    public float cubeSize = 10.0f; // Adjust the size of each cube

    void Start()
    {
        float halfSize = cubeSize / 2f;

        GameObject c1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        c1.transform.position = new Vector3(0, 0, 0);
        c1.transform.localScale = new Vector3(0, cubeSize, cubeSize);
        c1.transform.rotation = Quaternion.identity;

        GameObject c2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        c2.transform.position = new Vector3(cubeSize, 0, 0);
        c2.transform.localScale = new Vector3(0, cubeSize, cubeSize);
        c2.transform.rotation = Quaternion.identity;

        GameObject c3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        c3.transform.position = new Vector3(halfSize, 0, 0);
        c3.transform.localScale = new Vector3(0, cubeSize, cubeSize);
        c3.transform.rotation = Quaternion.Euler(0, 0, 90);

        GameObject c4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        c4.transform.position = new Vector3(halfSize, cubeSize, 0);
        c4.transform.localScale = new Vector3(0, cubeSize, cubeSize);
        c4.transform.rotation = Quaternion.Euler(0, 0, 90);

        GameObject c5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        c5.transform.position = new Vector3(halfSize, 0, -halfSize);
        c5.transform.localScale = new Vector3(0, cubeSize, cubeSize);
        c5.transform.rotation = Quaternion.Euler(0, 90, 0);

        GameObject c6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        c6.transform.position = new Vector3(halfSize, 0, halfSize);
        c6.transform.localScale = new Vector3(0, cubeSize, cubeSize);
        c6.transform.rotation = Quaternion.Euler(0, 90, 0);
    }

    void Update()
    {
        
    }
}
