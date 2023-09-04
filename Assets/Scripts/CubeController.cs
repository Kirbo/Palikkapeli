using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField]
    JumpController[] jumpers;

    [SerializeField]
    float JumpPower = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        jumpers = gameObject.GetComponentsInChildren<JumpController>();
        for (int i = 0; i < jumpers.Length; i++)
        {
            jumpers[i].setText((i + 1).ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        int id = -1;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            id = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            id = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            id = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            id = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            id = 4;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            id = 5;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            id = 6;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            id = 7;
        }

        if (id != -1)
        {
            jumpers[id].Jump(JumpPower);
        }
    }
}
