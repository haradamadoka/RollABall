using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*î‰ärââéZéq
         True:ê^
         False:ãU
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
            Debug.Log("xÇ∆yÇÕìôÇµÇ¢Ç≈Ç∑");//falseÇÃÇΩÇﬂï\é¶Ç≥ÇÍÇ»Ç¢
        }
        trueOrFalse = (x != y);
        if (trueOrFalse)
        {
            Debug.Log("xÇ∆yÇÕìôÇµÇ≠Ç»Ç¢Ç≈Ç∑");//trueÇÃÇΩÇﬂï\é¶Ç≥ÇÍÇÈ
        }

        //á@ñ‚ëË
        x = 10;
        y = 5;
        
        if (x>y)
        {
            Debug.Log("xÇÕyÇÊÇËëÂÇ´Ç¢");
        }


        //áAñ‚ëË
        string name1 = "Mike";
        string name2 = "Mike";

        if (name1==name2)
        {
            Debug.Log("ìÒÇ¬ÇÃñºëOÇÕìØÇ∂Ç≈Ç∑");
        }


        //áBñ‚ëË
        int age = 20;

        if (age>=20)
        {
            Debug.Log("ê¨êlÇ≈Ç∑");
        }
        else
        {
            Debug.Log("ñ¢ê¨îNÇ≈Ç∑");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
