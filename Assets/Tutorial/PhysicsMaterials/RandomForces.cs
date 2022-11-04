using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForces : MonoBehaviour
{
    Rigidbody ballRigibody;

    // Start is called before the first frame update
    void Start()
    {
        ballRigibody = this.GetComponent<Rigidbody>();

        Vector3 randomForce = 125.0f *  Random.insideUnitSphere;

        ballRigibody.AddForce(randomForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
