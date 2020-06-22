using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeNet : MonoBehaviour
{
    public GameObject explosion;
    GameObject net;

    // Use this for initialization
    void Start()
    {
        GameObject net = GameObject.Find("NetBig");
    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter2D(Collider2D other)
    {
    
   
        if (other.tag == "Player")
        {
            GameObject net = GameObject.Find("NetBig");
            Destroy(net);
            Debug.Log("Destroed");
            Instantiate(explosion, net.transform.position, net.transform.rotation);
            Debug.Log("exploded");
        }
    }

}
