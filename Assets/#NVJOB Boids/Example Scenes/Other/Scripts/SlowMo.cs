﻿using UnityEngine;


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


public class SlowMo : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public AudioSource[] audios;


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    void Awake()
    {
        //--------------

        Time.timeScale = 1.0f;

        //--------------
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    void LateUpdate()
    {
        //--------------

        if (Input.GetMouseButtonDown(0))
        {
            if (Time.timeScale != 0.33f)
            {
                Time.timeScale = 0.33f;
                for (int i = 0; i < audios.Length; i++) audios[0].pitch = 0.5f;
            }
            else if (Time.timeScale != 1.0f)
            {
                Time.timeScale = 1.0f;
                for (int i = 0; i < audios.Length; i++) audios[0].pitch = 1.0f;
            }
        }

        //--------------
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    void OnApplicationQuit()
    {
        //--------------

        Time.timeScale = 1.0f;

        //--------------
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}