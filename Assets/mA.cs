using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mA : MonoBehaviour
{
    int a, b;
    void Start()
    {
        a = 5;
        b = 5;
        Debug.Log($"startGit{TwoMath(a,b)}");
    }

    int TwoMath(int num,int num2) 
    {
        int answer = num + num2;
        return answer*num2;
    }
}
