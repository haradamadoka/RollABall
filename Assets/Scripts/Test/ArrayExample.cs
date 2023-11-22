using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    //Œ±‚Ì“_”‚ğ•Û‘¶‚·‚é‚½‚ß‚Ì‚T‚Â—e—Ê‚Ì‚ ‚é”z—ñ‚ğéŒ¾
    int[] testScores = new int[5];

    //‰‰K‡@
    int[] numbers = { 5, 8, 12, 7, 3 };

    //‰‰K‡A
    string[] fruits = { "apple", "banana", "cherry", "date", "elderberry" };

    //‰‰K‡B
    int[] scores = { 78, 85, 90, 72, 88, 60 };


    List<int> testNum = new List<int>();

    //‰‰K‡@
    List<int> listNumbers = new List<int> { 1, 2, 3, 4, 5 };
    //‰‰K‡A
    List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple" };
    //‰‰K‡B
    List<string> listFruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

    // Start is called before the first frame update
    void Start()
    {
        testScores[0] = 85;
        testScores[1] = 90;
        testScores[2] = 78;
        testScores[3] = 88;
        testScores[4] = 76;

        Debug.Log(testScores[1]);//90

        Debug.Log(numbers[2]);//‡@12

        Debug.Log(fruits[2]);//‡Acherry

        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        Debug.Log(sum);//‡B


        testNum.Add(1);
        testNum.Add(2);
        testNum.Add(3);

        Debug.Log(testNum[0]);
        testNum.Remove(2);
        Debug.Log(testNum.Count);

        //‡@
        foreach(int number in listNumbers)
        {
            Debug.Log(number);
        }

        //‡A
        colors.Remove("Green");
        for(int i = 0; i < colors.Count; i++)
        {
            Debug.Log(colors[i]);
        }

        //‡B
        if (listFruits.Contains("Cherry"))
        {
            Debug.Log("Cherry‚ªŠÜ‚Ü‚ê‚Ä‚¢‚é");
        }
        else
        {
            Debug.Log("Cherry‚ªŠÜ‚Ü‚ê‚Ä‚¢‚È‚¢");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
