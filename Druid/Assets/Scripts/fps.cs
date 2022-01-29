using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fps : MonoBehaviour
{
    public Text textFps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textFps.text = ((int)(1.0f / Time.smoothDeltaTime)).ToString();
        
       
    }
}
