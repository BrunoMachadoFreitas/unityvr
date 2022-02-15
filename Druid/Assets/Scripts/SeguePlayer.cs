using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SeguePlayer : MonoBehaviour
{

    public float movementSpeed = 20f;
    public float rotationSpeed = 100f;

    private bool isWondering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    public bool isWalking = false;
    bool podeAndar = false;
    public GameObject somInicio;

    Rigidbody rb;
    Animator animator;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        StartCoroutine("podeIrIdle");
    }

    // Update is called once per frame
    void Update()
    {
        if (podeAndar)
        {
            if (isWondering == false)
            {
                StartCoroutine(Wander());
            }

            if (isRotatingRight == true)
            {
                transform.Rotate(transform.up * Time.deltaTime * rotationSpeed);
            }
            if (isRotatingLeft == true)
            {
                transform.Rotate(transform.up * Time.deltaTime * -rotationSpeed);
            }

            if (isWalking == true)
            {
                rb.AddForce(transform.forward * movementSpeed);
                animator.SetBool("estaMover", true);
            }

            if (isWalking == false)
            {
                animator.SetBool("estaMover", false);
            }
        }
    }

    IEnumerator Wander()
    {
        int rotationTime = UnityEngine.Random.Range(1, 3);
        int rotateWait = UnityEngine.Random.Range(1, 3);
        int rotateDirection = UnityEngine.Random.Range(1, 3);
        int walkWait = UnityEngine.Random.Range(1, 3);
        int walkTime = UnityEngine.Random.Range(10, 15);

        isWondering = true;

        yield return new WaitForSeconds(walkWait);

        isWalking = true;

        yield return new WaitForSeconds(walkTime);

        isWalking = false;

        yield return new WaitForSeconds(rotateWait);

        if(rotateDirection == 1)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingLeft = false;
        }
        if(rotateDirection == 2)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingRight = false;
        }

        isWondering = false;


    }

    IEnumerator podeIrIdle()
    {
        yield return new WaitForSeconds(5);
        animator.SetBool("tocaIdle", true);
        podeAndar = true;
        somInicio.gameObject.SetActive(false);
    }
}
