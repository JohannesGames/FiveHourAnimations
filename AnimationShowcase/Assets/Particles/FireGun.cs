using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;
    [SerializeField] private Transform barrelLocation;

    public void PlayParticle()
    {
        var part = Instantiate(particle, barrelLocation.position, Quaternion.identity, barrelLocation);
        part.transform.forward = barrelLocation.TransformDirection(Vector3.forward);
    }
}
