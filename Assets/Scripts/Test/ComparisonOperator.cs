using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*��r���Z�q
         True:�^
         False:�U
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
            Debug.Log("x��y�͓������ł�");//false�̂��ߕ\������Ȃ�
        }
        trueOrFalse = (x != y);
        if (trueOrFalse)
        {
            Debug.Log("x��y�͓������Ȃ��ł�");//true�̂��ߕ\�������
        }

        //�@���
        x = 10;
        y = 5;
        
        if (x>y)
        {
            Debug.Log("x��y���傫��");
        }


        //�A���
        string name1 = "Mike";
        string name2 = "Mike";

        if (name1==name2)
        {
            Debug.Log("��̖��O�͓����ł�");
        }


        //�B���
        int age = 20;

        if (age>=20)
        {
            Debug.Log("���l�ł�");
        }
        else
        {
            Debug.Log("�����N�ł�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
