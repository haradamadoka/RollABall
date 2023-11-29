using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringUtility : MonoBehaviour
{
    public static string SecondsToTwoDecimalPlaces(float time)
    {
        return time.ToString("F2");
    }
}
