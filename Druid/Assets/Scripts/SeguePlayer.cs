using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3 offset = new Vector3(-1.8f, 0.04f, 3.91f);


    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
