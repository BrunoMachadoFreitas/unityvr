using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripLivro : MonoBehaviour
{
    public GameObject Livro;

    public void fazAnimacao()
    {
        Livro.GetComponent<Animator>().Play("animaCubo");
    }
}
