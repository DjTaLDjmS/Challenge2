using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private DateTime time;

    [SerializeField]
    private int delay = 500;

    private void Start()
    {
        time = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if ((DateTime.Now - time).TotalMilliseconds > delay)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                time = DateTime.Now;
            }
        }
    }
}
