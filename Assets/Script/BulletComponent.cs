using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This BulletComponent class will contain the code for destroying the ball.
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Destroy object after a few seconds.
        Destroy(gameObject, 5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
