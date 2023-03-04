using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAround : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] Vector3 pivotAngle;
    [SerializeField] GameObject planet;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = 2000f;
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 Pivotposition = planet.transform.position;
        this.transform.RotateAround(Pivotposition, pivotAngle, rotationSpeed * Time.deltaTime);

        transform.position = (transform.position - planet.transform.position).normalized * distance + planet.transform.position;
    }
}
