using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetHop : MonoBehaviour
{
    [SerializeField] List<GameObject> planets;
    [SerializeField] int currentPlanet;
     float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        centerPlanet();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentPlanet = 0;
            height = 2000f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentPlanet = 1;
            height = 70000;
        }
    }
    void centerPlanet()
    {
        transform.position = Vector3.MoveTowards(transform.position, -planets[currentPlanet].transform.position, Mathf.Infinity);
    }
}
