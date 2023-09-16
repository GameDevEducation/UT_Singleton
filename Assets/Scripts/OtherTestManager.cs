using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherTestManager : Singleton<OtherTestManager>
{
    public void DoSomething()
    {
        Debug.Log("Hello I am the OtherTestManager");
    }
}
