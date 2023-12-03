using System.Collections;
using UnityEngine;

public class randomBounce : MonoBehaviour
{
    private Rigidbody _rb;
    private Renderer _renderer;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
        _rb.maxAngularVelocity = 3000;

        StartCoroutine(ChangeRotation());
    }

    private IEnumerator ChangeRotation()
    {
        while (true)
        {
            _rb.AddTorque(new Vector3(10 * UnityEngine.Random.Range(0, 3f), UnityEngine.Random.Range(0, 3f), UnityEngine.Random.Range(0, 3f)), ForceMode.VelocityChange);
            yield return new WaitForSeconds(1);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        _renderer.material.color = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
    }

    void Update()
    {
        
    }
}
