using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float nextDogSpawn;

    private void Start()
    {
        nextDogSpawn = Time.time + 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog(after every 1 second only)
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextDogSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextDogSpawn += 1.0f;
        }
    }
}
