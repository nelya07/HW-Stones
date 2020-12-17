using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Mover : MonoBehaviour
{
  private Rigidbody _rigidbody;
  private bool _isFlying = false;


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
      if (transform.position.y < 5)
      {
        _rigidbody.AddForce(Vector3.up * _rigidbody.mass * 1.05f);
      }
      if (Input.GetKey(KeyCode.Space))
      {
        _isFlying = false;
        _rigidbody.AddForce(Vector3.forward  * 3000f);
      }
    }

   
  }
}
