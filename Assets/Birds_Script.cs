using System;
using UnityEngine;

public class Birds_Script : MonoBehaviour
{
    public Rigidbody2D myrigidbody2d;
    public int jump = 11;
    public score logic;
    public bool birdalive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<score>();
        GetComponent<Rigidbody2D>().freezeRotation = true;
     
    }

    // Update is called once per frame
    void Update()
    {
        // Check for input depending on the platform
        if (Input.GetKeyDown(KeyCode.Space) && birdalive)
        {
            // Debug.Log("Jump");
            myrigidbody2d.velocity = Vector2.up * jump;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
 
           
            // End the game when the bird hits an obstacle
            logic.gameOver();
            // Set birdalive to false
            birdalive = false;
        
    }


}