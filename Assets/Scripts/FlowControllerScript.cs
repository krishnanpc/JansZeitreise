using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowControllerScript : MonoBehaviour
{
    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (player.transform.localScale.x == 1f)

            {

                player.GetComponent<PlayerController>().speedMod = -2f;

            }
            else

            {
                player.GetComponent<PlayerController>().speedMod = 0f;

            }
            player.transform.localScale = new Vector3(-1f, 1f, 1f);
            player.GetComponent<PlayerController>().movePlayer();




        }
    }
}
