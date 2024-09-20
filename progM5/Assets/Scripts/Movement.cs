using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{ 
[SerializeField] private float speed = 50f;
[SerializeField] private float rotSpeed = 50f;
private Rigidbody rb;
void Start()
{
    rb = gameObject.GetComponent<Rigidbody>();
}

void FixedUpdate()
{
    Vector3 newPosistion = new Vector3(0f, 0f, Input.GetAxis("Vertical")).normalized * speed;
    rb.MovePosition(rb.position + transform.TransformDirection(newPosistion) * Time.fixedDeltaTime);

    float horizontal = Input.GetAxis("Horizontal") * rotSpeed * Time.fixedDeltaTime;
    Quaternion rotation = Quaternion.Euler(Vector3.up * horizontal);
    rb.MoveRotation(rb.rotation * rotation);
}
}
