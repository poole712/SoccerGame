using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerController
{
    player1,
    player2
}

public class PaddleInput : MonoBehaviour
{
    public PlayerController playerSetting;
    public float speed;
    public float clampValue;
    public string axisName;
    public string punchAxis;
    private bool punching;
    public float punchPower;

    private Rigidbody paddleRB;


    private void Start()
    {
        paddleRB = GetComponent<Rigidbody>();

        if (playerSetting == PlayerController.player1)
        {
            axisName = "player1";
        }
        if (playerSetting == PlayerController.player2)
        {
            axisName = "player2";
        }
    }

    // Update is called once per frame
    void Update()
    {

        MovePaddle(Input.GetAxis(axisName));

        if (Input.GetKey(KeyCode.Space))
        {
            //punching = true;
        }
        if (punching == true)
        {
            Punch();
        }


    }



    public void MovePaddle(float amountToMove)

    {
        Vector3 clampedGameObjectPosition =  gameObject.transform.position + new Vector3(amountToMove * speed,0, 0 );

        clampedGameObjectPosition.x = Mathf.Clamp(clampedGameObjectPosition.x, -clampValue, clampValue);



        gameObject.transform.position = clampedGameObjectPosition;


    }
    public void Punch()
    {
        paddleRB.AddForce(transform.forward * punchPower);
    }
}
