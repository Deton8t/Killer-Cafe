using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public KeyCode movingUp;
    public KeyCode movingDown;
    public KeyCode movingRight;
    public KeyCode movingLeft;
    public Animator mover;

    void Update()
    {
        if(Input.GetKey(movingUp) || Input.GetKey(movingDown))
        {
            mover.SetTrigger("Vertical Trigger");
        }
        else if(Input.GetKey(movingLeft) || Input.GetKey(movingRight))
        {
            mover.SetTrigger("Horizontal Trigger");
        }
        else
        {
            mover.SetTrigger("Idle Trigger");
        }
    }
}
