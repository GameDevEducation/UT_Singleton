using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : Singleton<TestManager>
{
    public void DoSomething()
    {
        Debug.Log("Hello I am the TestManager");
    }
}
