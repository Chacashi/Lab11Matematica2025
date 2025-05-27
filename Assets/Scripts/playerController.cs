using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    Rigidbody _compRigidbody;
    [SerializeField] float jumpForce;
    [SerializeField] float rotationSpeed;


    private float _rotationDirection;
    [SerializeField] float ImpactIntensityHorizontal;
    
    public static event Action OnDestroyPlayer;

    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody>();
    }
    private void Start()
    {

        UpForce();
    }

   

    private void FixedUpdate()
    {
        _compRigidbody.rotation = _compRigidbody.rotation* Quaternion.Euler(Vector3.forward * _rotationDirection * Time.deltaTime);
    }

    public void UpForce()
    {
        _compRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        Physics.gravity = new Vector3(0, -9.81f, 0);
        _rotationDirection = rotationSpeed * -1;
        _compRigidbody.rotation = Quaternion.Euler(Vector3.forward * 45);
    }
  
    public void DownForce()
    {
        _compRigidbody.AddForce(Vector3.down * jumpForce, ForceMode.Impulse);
        Physics.gravity = new Vector3(0, 9.81f, 0);
        _rotationDirection = rotationSpeed;
        _compRigidbody.rotation = Quaternion.Euler(Vector3.forward   * -45);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other != null && other.gameObject.tag == "Obstacule")
        {
            Destroy(gameObject);
            OnDestroyPlayer?.Invoke();
        }

        if (other != null && other.gameObject.tag == "ImpulseUp")
        {
            _compRigidbody.AddForce(Vector3.left * ImpactIntensityHorizontal);
        }
        if (other != null && other.gameObject.tag == "ImpulseDown")
        {
            _compRigidbody.AddForce(Vector3.left * ImpactIntensityHorizontal);
        }
    }
}
