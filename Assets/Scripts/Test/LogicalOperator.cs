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
            Debug.Log("ðŒ‚P‚ÆðŒ‚Q‚Ítrue‚Å‚·");
        }
        if(condition1 || condition2)//true
        {
            Debug.Log("ðŒ‚P‚Ü‚½‚ÍðŒ‚Q‚ªtrue‚Å‚·");
        }

        //‡@–â‘è
        int a = 10;
        int b = 3;

        if (a >= 10 && a != 15 && b <= 5)
        {

        }

        //‡A–â‘è
        bool isRaining = true;
        bool hasUmbrella = true;

        if (!isRaining || (isRaining && hasUmbrella))
        {
            Debug.Log("‰Æ‚ðo‚é");
        }
    }

    void CheckCondition()
    {
        //&&F˜_—ÏiANDj
        Debug.Log(condition1 && condition2);
        // ||F˜_—˜aiORj
        Debug.Log(condition1 || condition2);
        // !F”Û’èiNOTj
        Debug.Log(!condition1);
        // ^F”r‘¼“I˜_—˜aiXORj
        Debug.Log(condition1 ^ condition2);
    }


    


    // Update is called once per frame
    void Update()
    {
        
    }
}
