using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbutmove : MonoBehaviour
{
    Vector2 xMove;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        xMove = new Vector2(1.0f, 0.0f);
        //Debug.Log (xMove);
        player = gameObject.transform;

    }
    //help ;-;
    // Update is called once per frame
    void Update()
    {
        float arrowInput = Input.GetAxis("Horizontal");
        float upDown = Input.GetAxis("Vertical");
        xMove.x = arrowInput;
        player.Translate(xMove*Time.deltaTime);

        //transform.Translate(1.0f, 0.0f, 0.0f);

    }
}
