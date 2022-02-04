using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3 offset = new Vector3(-1.8f, 0.04f, 3.91f);
    private Animator anime;

    public GameObject[] teleports;

    private void Start()
    {
        anime = this.gameObject.GetComponent<Animator>();
    }

    private void LateUpdate()
    {
        transform.position = target.position + offset;
        animaAnimal();
    }

    void animaAnimal()
    {
        for (int i = 0; i < teleports.Length; i++)
        {
            if (teleports[i].GetComponent<cod_teleporta>().isMoving)
            {
                anime.SetBool("estaMover", true);
            }
            else
            {
                anime.SetBool("estaMover", false);
            }
        }
    }
}
