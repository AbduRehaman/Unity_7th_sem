using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geoTransform : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation = new Vector3(0f, 1f, 0f);
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _movementSpeed = 1f;
    [SerializeField] private float _scaleSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        transform.position += new Vector3(xDirection, 0f, zDirection) * _movementSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(_rotation * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.X))
        {
            transform.localScale -= new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;
        }
    }
}
