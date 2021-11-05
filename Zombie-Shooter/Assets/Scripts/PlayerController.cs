using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Vector3 velocity;
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    public void move(Vector3 _velocity){
        velocity = _velocity;
    }

    public void lookAt(Vector3 lookPoint){
        Vector3 newPoint = new Vector3(lookPoint.x, transform.position.y, lookPoint.z);
        transform.LookAt(newPoint);
    }

    public void FixedUpdate() {
        myRigidbody.MovePosition(myRigidbody.position + velocity * Time.fixedDeltaTime);
    }
}
