using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour
{
    // Update is called once per frame
    public Transform[] targets;
    public float speed;
    private Transform target;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        target = targets[0];
    }

   
    void Update()
    {
        num = UnityEngine.Random.Range(0, targets.Length);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        this.gameObject.transform.LookAt(target, Vector3.up);
        try
        {
            for (int i = 0; i < targets.Length; i++)
            {
                if (this.gameObject.transform.position == targets[i].gameObject.transform.position)
                {
                    if (this.gameObject.transform.position == targets[targets.Length - 1].gameObject.transform.position)
                    {
                        target = targets[0];
                    }
                    
                    target = targets[num];
                }

            }
        }catch(IndexOutOfRangeException e)
        {

        }


    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);
       
    }

   
}
