using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField]
    JumpController[] jumpers;

    [SerializeField]
    float JumpPower = 50.0f;

    Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        jumpers = gameObject.GetComponentsInChildren<JumpController>();
        for (int i = 0; i < jumpers.Length; i++)
        {
            jumpers[i].setText( (i+1).ToString());
        }
        Physics.gravity = new Vector3(0, -0.5f, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.Alpha1))
        {
            jumpers[0].Jump(JumpPower);
        }
        
        if (Input.GetKey(KeyCode.Alpha2))
        {
            jumpers[1].Jump(JumpPower);
        }
        
        if (Input.GetKey(KeyCode.Alpha3))
        {
            jumpers[2].Jump(JumpPower);
        }
        
        if (Input.GetKey(KeyCode.Alpha4))
        {
            jumpers[3].Jump(JumpPower);
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            jumpers[0].Jump(-JumpPower);
        }
        
        if (Input.GetKey(KeyCode.Alpha6))
        {
            jumpers[1].Jump(-JumpPower);
        }
        
        if (Input.GetKey(KeyCode.Alpha7))
        {
            jumpers[2].Jump(-JumpPower);
        }
        
        if (Input.GetKey(KeyCode.Alpha8))
        {
            jumpers[3].Jump(-JumpPower);
        }
        
        
        /*
        if (Input.GetKey(KeyCode.Alpha5))
        {
            jumpers[4].Jump(JumpPower);
        }
        
        if (Input.GetKey(KeyCode.Alpha6))
        {
            jumpers[5].Jump(JumpPower);
        }
        
        if (Input.GetKey(KeyCode.Alpha7))
        {
            jumpers[6].Jump(JumpPower);
        }
        
        if (Input.GetKey(KeyCode.Alpha8))
        {
            jumpers[7].Jump(JumpPower);
        }
        */
    }
}
