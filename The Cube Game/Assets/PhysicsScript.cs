using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsScript : MonoBehaviour
{
    private const int Damage = 1;
    Rigidbody ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
         {
             ourRigidBody.AddExplosionForce(500,transform.position+Vector3.down,2);
         }
        
    }


    
    private void OnCollisionEnter(Collision collision)
    {
     Health objectHitHealth =   collision.gameObject.GetComponent<Health>();

        if (objectHitHealth)
        {
            print("Found Health scipt in object hit");
            objectHitHealth.takeDamage(1);
        }
        else
        {
            print("Didn't find Health script in object hit");
        }
    }
}
