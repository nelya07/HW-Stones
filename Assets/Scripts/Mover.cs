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
        _rigidbody.AddForce(Vector3.up * 1.1f, ForceMode.Acceleration);
      }
      
      if (Input.GetKey(KeyCode.Space))
      {
        _isFlying = false;
        _rigidbody.AddForce(Vector3.forward*30f, ForceMode.Impulse);
      }
    }
  }
}
