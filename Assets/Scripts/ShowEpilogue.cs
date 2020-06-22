using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEpilogue : MonoBehaviour
{

public  GameObject level3Box;


public GameObject epilogue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(level3Box.active==true)
        {

            if (Input.GetKeyDown(KeyCode.Return))
            {level3Box.SetActive(false);
               epilogue.SetActive(true);

            }
        }
    }
}
