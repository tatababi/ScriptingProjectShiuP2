using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //show the position of game object at the start of the game, specifically the x value 
     Debug.Log(transform.position.x);
    
    
    
    }
    // Update is called once per frame
    void Update()
    {
        //if our game objects y value is bellow 5, we want to show a message on the console
        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm aboyt to hit the ground");
        }

    }
}
