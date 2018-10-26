using System;
using System.Collections;
using UnityEngine;

class Utility
{
    //外記のように呼び出してください
    //StartCoroutine(DelayMethod(1.0f, ()=>{ }));
    public static IEnumerator DelayMethod(float waitTime, Action action)
    {
        yield return new WaitForSeconds(waitTime);
        action();
    }
}