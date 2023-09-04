using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JumpController : MonoBehaviour
{
    public Rigidbody rbody;

    TMPro.TextMeshPro textComponent;

    [SerializeField]
    LayerMask groundMask;

    float usePower = 0;

    [SerializeField]
    bool localSpace = false;

    // Start is called before the first frame update
    void Start()
    {
        rbody = transform.parent.GetComponent<Rigidbody>();
        textComponent = transform.GetComponentInChildren<TextMeshPro>();
    }

    public void setText(string text)
    {
        textComponent.text = text;
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.transform.rotation = Quaternion.identity;

        if (IsGrounded())
        {
            textComponent.color = Color.green;
        }
        else
        {
            textComponent.color = Color.red;
        }

        if (usePower != 0)
        {
            textComponent.color = Color.yellow;
        }
    }

    void FixedUpdate()
    {
        if (usePower != 0)
        {
            if (localSpace)
                rbody.AddForceAtPosition(transform.up * usePower, transform.position);
            else
                rbody.AddForceAtPosition(Vector3.up * usePower, transform.position);
        }
        usePower = 0;
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, 0.25f, groundMask);
    }

    public void Jump(float power)
    {
        usePower = power;
    }
}
