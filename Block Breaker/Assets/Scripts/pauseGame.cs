﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{
    public static bool GameIsPaused = true;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if (GameIsPaused){
                Resume();
            }else{
                Pause();
            }
        }
    }
    void Resume(){
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause(){
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
