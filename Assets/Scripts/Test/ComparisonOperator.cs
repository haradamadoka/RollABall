using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*比較演算子
         True:真
         False:偽
         */
        int x = 5;
        int y = 8;
        Debug.Log(x == y);//false
        Debug.Log(x != y);//true
        Debug.Log(x > y);//false
        Debug.Log(x < y);//true
        Debug.Log(x >= y);//false
        Debug.Log(x <= y);//true
        Debug.Log(x > 5);//false
        Debug.Log(x >= 5);//true

        bool trueOrFalse = (x == y);//false
        if (trueOrFalse)
        {
            Debug.Log("xとyは等しいです");//falseのため表示されない
        }
        trueOrFalse = (x != y);
        if (trueOrFalse)
        {
            Debug.Log("xとyは等しくないです");//trueのため表示される
        }

        //�@問題
        x = 10;
        y = 5;
        
        if (x>y)
        {
            Debug.Log("xはyより大きい");
        }


        //�A問題
        string name1 = "Mike";
        string name2 = "Mike";

        if (name1==name2)
        {
            Debug.Log("二つの名前は同じです");
        }


        //�B問題
        int age = 20;

        if (age>=20)
        {
            Debug.Log("成人です");
        }
        else
        {
            Debug.Log("未成年です");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
