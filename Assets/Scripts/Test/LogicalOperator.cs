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
            Debug.Log("πPΖπQΝtrueΕ·");
        }
        if(condition1 || condition2)//true
        {
            Debug.Log("πPά½ΝπQͺtrueΕ·");
        }

        //@βθ
        int a = 10;
        int b = 3;

        if (a >= 10 && a != 15 && b <= 5)
        {

        }

        //Aβθ
        bool isRaining = true;
        bool hasUmbrella = true;

        if (!isRaining || (isRaining && hasUmbrella))
        {
            Debug.Log("Ζπoι");
        }
    }

    void CheckCondition()
    {
        //&&F_ΟiANDj
        Debug.Log(condition1 && condition2);
        // ||F_aiORj
        Debug.Log(condition1 || condition2);
        // !FΫθiNOTj
        Debug.Log(!condition1);
        // ^FrΌI_aiXORj
        Debug.Log(condition1 ^ condition2);
    }


    


    // Update is called once per frame
    void Update()
    {
        
    }
}
