using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Vector3 offset;

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float translateSpeed;

    // Update is called once per frame
    void Update()
    {
        HandleTranslation();
        HandleRotation();
    }

    void HandleTranslation()
    {
        Vector3 targetPosition = target.TransformPoint(offset);
        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            translateSpeed * Time.deltaTime
        );
    }

    void HandleRotation()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            rotation,
            translateSpeed * Time.deltaTime
        );
    }
}
