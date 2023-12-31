using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRigidBody;
    private BallData ballData;
    private InGameTimer InGameTimer;

    private void Start()
    {
        ballRigidBody = this.GetComponent<Rigidbody>();
        var ballData = new BallData(5);
        Debug.Log(ballData.GetHitPoint);//5
    }

    private void Update()
    {
        if (InGameTimer.GetTimerTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void BallMove(Vector3 direction)
    {
        ballRigidBody.AddForce(direction);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            Debug.Log("Damage");
        }
    }
}
