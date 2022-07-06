using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class pl : MonoBehaviour
{
    Rigidbody _playerRb;

    float _velocityX, _velocityY;
    float _posX, _posY, _posZ;
    float _speed = 80;

    public bool resetAccOfPhone = true;
    private void Start()
    {
        Input.gyro.enabled = true;
        _playerRb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        
        
        _velocityX = -Input.gyro.rotationRate.z * _speed;
        _velocityY = Input.gyro.rotationRate.x * _speed;
        if (_velocityX >= -_speed / 80 && _velocityX <= _speed / 80)
        {
            _velocityX = 0;
        }
        if (_velocityY >= -_speed / 80 && _velocityY <= _speed / 80)
        {
            _velocityY = 0;
        }
        _posX = transform.position.x;
        _posY = transform.position.y;
        _posZ = transform.position.z;
        _posX = Mathf.Clamp(_posX, -20, 20);
        _posY = Mathf.Clamp(_posY, -20, 20);
        _posZ = Mathf.Clamp(_posZ, -20, 20);
        transform.position = new Vector3(_posX, _posY, _posZ);
    }
    private void FixedUpdate()
    {
        _playerRb.velocity = new Vector3(_velocityX, _velocityY, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("carptim");
    }
}


