using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MUGTestBeater : MonoBehaviour
{
    [Range(1, 300)]
    public float BPM = 70.0f; 
    public float offsetSec = 0.0f;
    float countDown = 0.0f, beatProcess = 0.0f;
    int beatCounter = 0;

    public List<IBeatReciever> beatRecieverList = new List<IBeatReciever>();

	// Use this for initialization
	void Start ()
    {
        countDown = offsetSec;
	}
	
	// Update is called once per frame
	void Update ()
    {
        countDown -= Time.deltaTime;

        if (countDown <= 0)
        {
            beatCounter++;
            countDown += (60.0f / BPM);
        }

        beatProcess = 1.0f - countDown / (60.0f / BPM);

        foreach(IBeatReciever b in beatRecieverList)
        {
            b.updateBeat(beatCounter, beatProcess);
        }
	}
}
