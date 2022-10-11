using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBasic : MonoBehaviour
{
    public float speed = 3f;
    Vector3 playerDirection;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            playerDirection += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerDirection += Vector3.back;
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerDirection += Vector3.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerDirection += Vector3.right;
        }



        MovePlayer(playerDirection);

    }

    private void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }




}
