using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringConcatenation : MonoBehaviour
{
    string name = "John";
    int age = 20;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is John." + "I'm 20 years old.");
        //.の後にスペースがある
        Debug.Log("My name is John. " + "I'm 20 years old.");
        //Iの前にスペースがある
        Debug.Log("My name is John." + " I'm 20 years old.");
        //スペースだけの文字列を連結している
        Debug.Log("My name is John." + " "+"I'm 20 years old.");

        //変数を使用した文字列連結
        Debug.Log("My name is" + name + "." + "I'm" + age + "years old.");

        //文字列補完
        Debug.Log($"My name is {name}.I'm {age} years old.");

        //string.Format
        Debug.Log(string.Format("My name is {0}.I'm {1} years old.", name, age));

        //double型からint型へ変換
        int x = (int)20.9;
        Debug.Log(x);//20

        //string型からint型へ変換
        int y = int.Parse("123");
        Debug.Log(y);//123
    }

    
}
