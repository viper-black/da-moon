using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAround : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] Vector3 pivotAngle;
    [SerializeField] GameObject Center;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 Pivotposition = Center.transform.position;
        this.transform.RotateAround(Pivotposition, pivotAngle, rotationSpeed * Time.deltaTime);
    }
}
