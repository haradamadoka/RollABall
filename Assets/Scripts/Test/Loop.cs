using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ForLoop();
        //ForeachLoop();
        //WhileLoop();
        //DoWhileLoop();


        //①問題
        int n = 10;
        while (n>0)
        {
            if (n % 2 == 0) //nが偶数の場合
            {
                n /= 2;
            }
            else //nが奇数の場合
            {
                n -= 1;
            }
            Debug.Log(n);//5,4,2,1,0
        }
    }

    

    void ForLoop()
    {
        Debug.Log("1~100まで数えます");
        for(int counter = 1; counter <= 100; counter++)
        {
            Debug.Log(counter);
        }
        Debug.Log("forループを終了します");
    }

    void ForeachLoop()
    {
        int[] scores = { 50, 80, 60, 80, 90 };
        foreach (var score in scores)
        {
            Debug.Log(score);// 50,80,60,80,90
        }
    }

    void WhileLoop()
    {
        Debug.Log("whileループで1~100まで数えます");
        int counter = 1;
        while (counter <= 100)
        {
            Debug.Log(counter);
            counter += 1;
        }
        Debug.Log("whileループを終了します");
    }

    void DoWhileLoop()
    {
        int counter = 200;
        Debug.Log("do whileループで1~100まで数えます");
        do
        {
            Debug.Log(counter);
            counter += 1;
        } while (counter <= 100);
        Debug.Log("do whileループを終了します");
    }


    //②問題
    private int distance = 10;

    // Update is called once per frame
    void Update()
    {
        do
        {
            distance -= 1;
            Debug.Log(distance);

            if (distance==0)
            {
                Debug.Log("目的地に到着しました！");
                gameObject.SetActive(false);
            }
        } while (distance>0);
    }
}
