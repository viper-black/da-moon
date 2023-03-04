using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    [SerializeField] Vector3 rotationSpeed;
    void Update()
    {
        this.transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
