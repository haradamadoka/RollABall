using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperator : MonoBehaviour
{
    bool condition1 = true;
    bool condition2 = false;
    // Start is called before the first frame update
    void Start()
    {
        //CheckCondition();
        if (condition1 && condition2)//false
        {
            Debug.Log("�����P�Ə����Q��true�ł�");
        }
        if(condition1 || condition2)//true
        {
            Debug.Log("�����P�܂��͏����Q��true�ł�");
        }

        //�@���
        int a = 10;
        int b = 3;

        if (a >= 10 && a != 15 && b <= 5)
        {

        }

        //�A���
        bool isRaining = true;
        bool hasUmbrella = true;

        if (!isRaining || (isRaining && hasUmbrella))
        {
            Debug.Log("�Ƃ��o��");
        }
    }

    void CheckCondition()
    {
        //&&�F�_���ρiAND�j
        Debug.Log(condition1 && condition2);
        // ||�F�_���a�iOR�j
        Debug.Log(condition1 || condition2);
        // !�F�ے�iNOT�j
        Debug.Log(!condition1);
        // ^�F�r���I�_���a�iXOR�j
        Debug.Log(condition1 ^ condition2);
    }


    


    // Update is called once per frame
    void Update()
    {
        
    }
}
