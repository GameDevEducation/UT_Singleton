using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayedLoad : MonoBehaviour
{
    public float DelayTime = 5.0f;
    public string NextScene;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("OnDelayedLoad", DelayTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDelayedLoad()
    {
        SceneManager.LoadScene(NextScene);
    }
}
