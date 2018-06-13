using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] bool lerpToSubject;
    [SerializeField] float speed;
    [SerializeField] GameObject subject;

    void Update()
    {
        if (lerpToSubject)
        {
            Quaternion originalRot = transform.rotation;
            transform.LookAt(subject.transform.position);
            Quaternion newRot = transform.rotation;
            transform.rotation = Quaternion.Lerp(originalRot, newRot, Time.deltaTime * speed);

        }
        else
        {
            transform.LookAt(subject.transform.position);
        }
    }
}
