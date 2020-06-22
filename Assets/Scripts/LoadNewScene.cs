using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
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


            if( SceneManager.GetActiveScene().name== "Level1-Era1")
            {
            SceneManager.LoadScene("Level2-Era2");
            SceneManager.UnloadSceneAsync("Level1-Era1");
            }
            else if (SceneManager.GetActiveScene().name == "Level2-Era2")
            {
                SceneManager.LoadScene("Level3-Era3");
                SceneManager.UnloadSceneAsync("Level2-Era2");
            }
            else if (SceneManager.GetActiveScene().name == "Level3-Era3")
            {
                SceneManager.LoadScene("EpilogueScene");
                SceneManager.UnloadSceneAsync("Level3-Era3");
            }

        }
    }
}
