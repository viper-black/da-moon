using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EVAscript : MonoBehaviour
{
    bool isOutside = false;
    [SerializeField] Vector3 EVApoint;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOutside == false)
        {
            this.transform.localPosition = EVApoint;
            isOutside = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && isOutside == true)
        {
            this.transform.localPosition = startPos;
            isOutside = false;
        }
    }
}
