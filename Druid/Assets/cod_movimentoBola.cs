using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cod_movimentoBola : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveX(gameObject, 9, 3).setEase(LeanTweenType.easeInOutSine).setDelay(2f); ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
