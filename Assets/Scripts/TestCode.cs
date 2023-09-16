using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestManager.Instance.DoSomething();
        OtherTestManager.Instance.DoSomething();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
