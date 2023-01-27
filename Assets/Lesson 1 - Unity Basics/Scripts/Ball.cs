using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private void Awake()
    {
       
        Debug.Log("Ball called Awake");
       
    }

    // Start is called before the first frame update
    void Start()
    {
       
        Debug.Log("Ball called Start");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("The ball Start method is running a for loop");
            if(i == 3)
            {
                Debug.Log("i is 3");
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
     
        Debug.Log("Ball is calling Update");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Debug.Log("Ball is calling FixedUpdate");
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        Debug.Log("Ball is calling LateUpdate");
        
    }
}
