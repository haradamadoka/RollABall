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


        //�@���
        int n = 10;
        while (n>0)
        {
            if (n % 2 == 0) //n�������̏ꍇ
            {
                n /= 2;
            }
            else //n����̏ꍇ
            {
                n -= 1;
            }
            Debug.Log(n);//5,4,2,1,0
        }
    }

    

    void ForLoop()
    {
        Debug.Log("1~100�܂Ő����܂�");
        for(int counter = 1; counter <= 100; counter++)
        {
            Debug.Log(counter);
        }
        Debug.Log("for���[�v���I�����܂�");
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
        Debug.Log("while���[�v��1~100�܂Ő����܂�");
        int counter = 1;
        while (counter <= 100)
        {
            Debug.Log(counter);
            counter += 1;
        }
        Debug.Log("while���[�v���I�����܂�");
    }

    void DoWhileLoop()
    {
        int counter = 200;
        Debug.Log("do while���[�v��1~100�܂Ő����܂�");
        do
        {
            Debug.Log(counter);
            counter += 1;
        } while (counter <= 100);
        Debug.Log("do while���[�v���I�����܂�");
    }


    //�A���
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
                Debug.Log("�ړI�n�ɓ������܂����I");
                gameObject.SetActive(false);
            }
        } while (distance>0);
    }
}
