using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Mover : MonoBehaviour
{
  private Rigidbody _rigidbody;
  private bool _isFlying = false;
  [SerializeField] private float _flyingHigh = 5;
  [SerializeField] private float _launchImpulse = 1.1f;
  [SerializeField] private float _throwImpulse = 30;


  private void Start()
  {
    _rigidbody = GetComponent<Rigidbody>();
  }

  private void Update()
  {
    if (Input.GetKey(KeyCode.W))
    {
      _isFlying = true;
    }

    if (_isFlying)
    {
      if (transform.position.y < _flyingHigh)
      {
        _rigidbody.AddForce(Vector3.up * _launchImpulse, ForceMode.Acceleration);
      }
      
      if (Input.GetKey(KeyCode.Space))
      {
        _isFlying = false;
        _rigidbody.AddForce(Vector3.forward * _throwImpulse, ForceMode.Impulse);
      }
    }
  }
}
