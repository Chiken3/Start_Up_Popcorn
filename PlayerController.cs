using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   

    public int moveTime;
    public int roll_of_Dice;
    public int i;            //目標座標
    Vector3 zero = new Vector3(0, 0, 0);
    Vector3 PlayerPos;
    Vector3 searchPos;
    Vector3 startPos = new Vector3(-5.5f, 0.0f);
    Vector3[] vin = new Vector3[32];   
    Vector3[] vout = new Vector3[48];

    // Start is calld before the first frame update
    void Start()
    {
        vin[0] = new Vector3(-5.5f, 0.0f);
        vin[1] = new Vector3(-4.8f, 1.0f);
        vin[2] = new Vector3(-4.2f, 1.8f);
        vin[3] = new Vector3(-3.6f, 2.3f);
        vin[4] = new Vector3(-2.9f, 2.7f);
        vin[5] = new Vector3(-2.3f, 3.2f);
        vin[6] = new Vector3(-0.9f, 2.2f);
    }



    // Update is called once per frame
    void Update()
    {

        Transform myTransform = this.transform;
        roll_of_Dice = UnityEngine.Random.Range(1, 6);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {          
           
            moveTime = roll_of_Dice;
            

            Vector3 pos = myTransform.position;
            pos.x = vin[i].x;    // x座標
            pos.y = vin[i].y;    // y座標
            pos.z += 0.0f;    // z座標は移動しない

            myTransform.position = pos;  // 座標を設定

            Debug.Log(moveTime);
            Debug.Log(myTransform.position); //正常に動作

        }        
    }
}
