using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{ 
    private float horizontalInput;
    private float verticalInput;
    private float steeringAngle;

    public float maxSteeringAngle = 50;
    public float speed = 50;
    public float maxSpeed = 22;

    private float speedCurrent = 0;

    private bool braked = false;
    public float maxBrakeTorque = 500;

    public WheelCollider collider_wheel_back_left;
    public WheelCollider collider_wheel_back_right;
    public WheelCollider collider_wheel_front_left;
    public WheelCollider collider_wheel_front_right;

    public Transform transform_wheel_back_left;
    public Transform transform_wheel_back_right;
    public Transform transform_wheel_front_left;
    public Transform transform_wheel_front_right;

    public void CarInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void Steering()
    {
        steeringAngle = maxSteeringAngle * horizontalInput;
        collider_wheel_front_left.steerAngle = steeringAngle;
        collider_wheel_front_right.steerAngle = steeringAngle;
    }

    private void Accelerate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        speedCurrent = rb.velocity.magnitude * 3.6f;
        
        if (speedCurrent <= maxSpeed) {
            collider_wheel_front_right.motorTorque = verticalInput * speed; 
            collider_wheel_front_left.motorTorque = verticalInput * speed;                    
                         
            collider_wheel_front_right.brakeTorque = 0;
            collider_wheel_front_left.brakeTorque = 0;
            collider_wheel_back_left.brakeTorque = 0;
            collider_wheel_back_right.brakeTorque = 0;

            speedCurrent = rb.velocity.magnitude * 3.6f;
        }
        else if (speedCurrent > maxSpeed)
        {
            collider_wheel_front_right.motorTorque = 0;
            collider_wheel_front_left.motorTorque = 0;

            collider_wheel_front_right.brakeTorque = 100000000000000000;
            collider_wheel_front_left.brakeTorque = 100000000000000000;
            collider_wheel_back_left.brakeTorque = 100000000000000000;
            collider_wheel_back_right.brakeTorque = 100000000000000000;
        }
    }

    private void Brake()
    {
        if(Input.GetButton("Jump"))
        {
            braked = true;
        }
        else
        {
            braked = false;
        }

        if (braked == true)
        {
            collider_wheel_back_left.brakeTorque = maxBrakeTorque * 1000;
            collider_wheel_back_right.brakeTorque = maxBrakeTorque * 1000;

            collider_wheel_back_left.motorTorque = 0;
            collider_wheel_back_right.motorTorque = 0;
        }

        if (braked == false)
        {
            collider_wheel_back_left.brakeTorque = 0;
            collider_wheel_back_right.brakeTorque = 0;
        }
    }

    private void UpdateWheels()
    {
        UpdateWheel(collider_wheel_back_left, transform_wheel_back_left);
        UpdateWheel(collider_wheel_back_right, transform_wheel_back_right);
        UpdateWheel(collider_wheel_front_left, transform_wheel_front_left);
        UpdateWheel(collider_wheel_front_right, transform_wheel_front_right);
    }

    private void UpdateWheel(WheelCollider _collider, Transform _transform)
    {
        Vector3 position = _transform.position;
        Quaternion quaternion = _transform.rotation;

        _collider.GetWorldPose(out position, out quaternion);

        _transform.position = position;
        _transform.rotation = quaternion;


    }

    private void FixedUpdate()
    {
        CarInput();
        Steering();
        Accelerate();
        Brake();
        Debug.Log(speedCurrent);
    }
}