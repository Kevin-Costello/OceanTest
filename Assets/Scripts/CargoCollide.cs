using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargoCollide : MonoBehaviour
{
    public GameObject treasure;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collected Cargo");
        GameObject e = Instantiate(treasure) as GameObject;
        e.transform.position = transform.position;

        Destroy(gameObject);
    }
}
