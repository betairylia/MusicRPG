﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class backGroundAudioPlayer : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    //nothing todo. (?)
	}
}
