using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private Vector2 startTouchPosition;
    private Vector2 currnetPosition;
    private Vector2 endTouchPosition;
    public bool stopTouch = false;

    public float swipeRange;
    public float tapRange;

    public PlayerMovement movement;
    //public Interact tap;

    // Start is called before the first frame update
    void Start()
    {

    }
        

    // Update is called once per frame
    void Update()
    {
        Swipe();
    }

    //This is the iPhone input detection
    public void Swipe()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            currnetPosition = Input.GetTouch(0).position;
            Vector2 Distance = currnetPosition - startTouchPosition;

            if (!stopTouch)
            {
                if (Distance.x < -swipeRange)
                {
                    Debug.Log("Swiped Left");
                    movement.MoveLeft();
                    stopTouch = true;
                }

                if (Distance.x > swipeRange)
                {
                    Debug.Log("Swiped Right");
                    movement.MoveRight();
                    stopTouch = true;
                }

                if (Distance.y > swipeRange)
                {
                    Debug.Log("Swiped Up");
                    movement.MoveUp();
                    stopTouch = true;
                }

                if (Distance.y < -swipeRange)
                {
                    Debug.Log("Swiped Down");
                    movement.MoveDown();
                    stopTouch = true;
                }
            }
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;

            endTouchPosition = Input.GetTouch(0).position;

            Vector2 Distance = endTouchPosition - startTouchPosition;

            if (Mathf.Abs(Distance.x) < tapRange && Mathf.Abs(Distance.y) < tapRange)
            {
                Debug.Log("Tap");
                //tap.Tap();
            }
        }
    }
}

