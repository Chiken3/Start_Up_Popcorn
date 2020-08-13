using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public int moveTime;
    public int roll_of_Dice;
    public int nowPos_num;
    public int terget_num;            

    Vector3 zero = new Vector3(0, 0, 0);
    Vector3 PlayerPos;
    Vector3 searchPos;
    Vector3 startPos = new Vector3(-5.5f, 0.0f);
    Vector3[] vin = new Vector3[32];
    Vector3[] vout = new Vector3[48];

    // mypositionに設定したstart positionを入れる
    void Start()
    {
        moveTime = 0;
        Transform myPosition = this.transform;
        myPosition.position = startPos;
        vin[0] = new Vector3(-5.5f, 0.0f);
        vin[1] = new Vector3(-4.8f, 1.0f);
        vin[2] = new Vector3(-4.2f, 1.8f);
        vin[3] = new Vector3(-3.6f, 2.3f);
        vin[4] = new Vector3(-2.9f, 2.7f);
        vin[5] = new Vector3(-2.3f, 3.2f);
        vin[6] = new Vector3(-0.9f, 2.2f);
        vin[7] = new Vector3(-0.9f, 3.5f);
    }


    // Update is called once per frame
    void Update()
    {

        Transform myPosition = this.transform;
        roll_of_Dice = UnityEngine.Random.Range(1, 6);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveTime = roll_of_Dice;
            for (int i = 0; i < 33; i++) // 自分の座標がどの配列番号か判定
            {        
                if(vin[i] == myPosition.position)
                {
                    nowPos_num = i;
                    break;
                }
            }

            
            terget_num = nowPos_num + moveTime;//配列番号にサイコロの目を足す
            
            Vector3 pos = myPosition.position;
            pos.x = vin[terget_num].x;    // x座標
            pos.y = vin[terget_num].y;    // y座標
            pos.z += 0.0f;    // z座標は移動しない

            myPosition.position = pos;  // 座標を設定

            Debug.Log($"今{nowPos_num}");
            Debug.Log($"サイコロ {moveTime}");
            Debug.Log($"位置{myPosition.position}"); 
        
        }
    }
}