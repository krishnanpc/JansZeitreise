using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMeDisappear : MonoBehaviour
{

    public int DelayTime;
    public bool OnEnter;

    void OnEnable()
    {

        if(OnEnter==false)
        {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(DisappearCoroutine());
        }
    }

    IEnumerator DisappearCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(DelayTime);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        this.gameObject.SetActive(false);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) &&  (OnEnter == true))
        {



            {
            this.gameObject.SetActive(false);
            }
        }
    }
}
