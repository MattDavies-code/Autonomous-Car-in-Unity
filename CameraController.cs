using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform followingCar;
    public Vector3 offset;
    public float followSpeed = 10;
    public float lookSpeed = 10;

    public void LookTarget()
    {
        Vector3 lookDirection = followingCar.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(lookDirection, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, lookSpeed * Time.deltaTime);
    }

    public void MoveTarget()
    {
        Vector3 targetPosition = followingCar.position + (followingCar.forward * offset.z) + (followingCar.right * offset.x) + (followingCar.up * offset.y);
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

    }

    public void FixedUpdate()
    {
        LookTarget();
        MoveTarget();
    }
}
