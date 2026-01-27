using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Buttonmanger : MonoBehaviour
{public void LoadNextLevel(int levelNum)
    {
        SceneManager.LoadScene(levelNum);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
