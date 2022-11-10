using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{

    Vector2 xMove;
    Transform player;
   // Vector3 flip;

    // Start is called before the first frame update
    void Start()
    {
        xMove = new Vector2(1.0f, 0.0f);
        player = gameObject.transform;
       // flip = new Vector3(1.0f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {

        float rightleft = Input.GetAxis("Horizontal");
        float upDown = Input.GetAxis("Vertical");
        xMove.y = upDown;
        xMove.x = rightleft;
        player.Translate(xMove * Time.deltaTime);
        
        //MAKE EM FLIP

        //if (rightleft > 0){

            //player.LocalScale= new Vector3 (20, 20, 1);


        //}


    }
}
