using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnvironment : MonoBehaviour
{
    public GameObject asteroid;

    void Start()
    {
        float startingSpeed = (float)2.5;

        GameObject asteroidx = Instantiate(asteroid);
        asteroidx.transform.position = new Vector3(50, 0, 0);
        asteroidx.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, startingSpeed);

        GameObject asteroidx2 = Instantiate(asteroid);
        asteroidx2.transform.position = new Vector3(-50, 0, 0);
        asteroidx2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -startingSpeed);

        GameObject asteroidy = Instantiate(asteroid);
        asteroidy.transform.position = new Vector3(0, 50, 0);
        asteroidy.GetComponent<Rigidbody>().velocity = new Vector3(startingSpeed, 0, 0);

        GameObject asteroidy2 = Instantiate(asteroid);
        asteroidy2.transform.position = new Vector3(0, -50, 0);
        asteroidy2.GetComponent<Rigidbody>().velocity = new Vector3(-startingSpeed, 0, 0);

        GameObject asteroidz = Instantiate(asteroid);
        asteroidz.transform.position = new Vector3(0, 0, 50);
        asteroidz.GetComponent<Rigidbody>().velocity = new Vector3(0, startingSpeed, 0);

        GameObject asteroidz2 = Instantiate(asteroid);
        asteroidz2.transform.position = new Vector3(0, 0, -50);
        asteroidz2.GetComponent<Rigidbody>().velocity = new Vector3(0, -startingSpeed, 0);
    }
}
