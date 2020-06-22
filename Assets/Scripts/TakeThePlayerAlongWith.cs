using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeThePlayerAlongWith : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            Debug.Log("Collision Detected");
            GameObject.Find("FlowMaintainer").SetActive(false);


        }
    }
}
