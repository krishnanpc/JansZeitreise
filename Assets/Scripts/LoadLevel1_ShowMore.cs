using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1_ShowMore : MonoBehaviour
{

    public GameObject EelStoryObject;
    public GameObject ShowMoreObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Level1-Era1");
            SceneManager.UnloadSceneAsync("StartScene");
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {

            EelStoryObject.SetActive(false);
            ShowMoreObject.SetActive(true);
        }
    }
}
