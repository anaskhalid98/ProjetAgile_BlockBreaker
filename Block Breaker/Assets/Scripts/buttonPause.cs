﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPause : MonoBehaviour
{
    bool isPaused = false;
    
    public void pauseGame(){
        if(isPaused){
            Time.timeScale = 1f;
            isPaused = false;
        }else{
            Time.timeScale = 0f;
            isPaused = true;
        }
    }
}
