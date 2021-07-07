using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject buttonStart;
    void Start()
    {
        buttonStart.SetActive(true);
        Time.timeScale = 0;
    }

    public void StartButton(){
        Time.timeScale = 1;
        buttonStart.SetActive(false);
    }
    
}
