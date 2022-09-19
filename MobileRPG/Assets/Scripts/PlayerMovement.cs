using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool playerMoving;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMoving = false;

        if (Input.GetKeyDown("up"))
        {
            MoveUp();
            playerMoving = true;
        }

        if (Input.GetKeyDown("down"))
        {
            MoveDown();
            playerMoving = true;
        }

        if (Input.GetKeyDown("left"))
        {
            MoveLeft();
            playerMoving = true;
        }

        if (Input.GetKeyDown("right"))
        {
            MoveRight();
            playerMoving = true;
        }
    }

    public void MoveUp()
    {
        Debug.Log("UP!");
        transform.Translate(new Vector3(0f, 1f, 0f));
    }

    public void MoveDown()
    {
        transform.Translate(new Vector3(0f, -1f, 0f));
        Debug.Log("DOWN!");
    }

    public void MoveLeft()
    {
        transform.Translate(new Vector3(-1f, 0f, 0f));
        Debug.Log("LEFT!");
    }

    public void MoveRight()
    {
        transform.Translate(new Vector3(1f, 0f, 0f));
        Debug.Log("RIGHT!");
    }
}
