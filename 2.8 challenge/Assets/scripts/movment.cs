using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    Animator animator;
    //Ridgidbody2d rb2d;
    //float thrust = 10.0f;
    //Move = new Vector2(0.0f, 0.0f);
    //player = gameObject.transform;

    // Start is called before the first frame update
    void Start()
    {
       //xMove = new Vector2(0.0f, 0.0f);
       player = gameObject.transform;
       xMove = new Vector2(0.0f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {

        float rightleft = Input.GetAxis("Horizontal");
        float upDown = Input.GetAxis("Vertical");
        xMove.y = upDown;
        xMove.x = rightleft;
        player.Translate(xMove * Time.deltaTime);
        animator = GetComponent<Animator>();
        //rb2d = GetCompenet<Ridgidbody2D>


        //LOOK LEFT OR RIGHT
        if (rightleft > 0)
        {
            player.localScale = new Vector2(5.0f, 5.0f);
        }
        if (rightleft < 0)
        {
            player.localScale = new Vector2(-5.0f, 5.0f);
        }

        //RUNNING ANIMATION
        if (rightleft > 0 || rightleft < 0)
        {
            animator.SetBool("Run", true);
        }else
        {
           animator.SetBool("Run", false);
        }
        //if (Input.GetKey(KeyCode.UpArrow))
        {
           // rbtd.AddForce(transform.up*)
        }

    }
}
