using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripLivro : MonoBehaviour
{
    public GameObject Livro;

    public GameObject ponteiro;
    public GameObject livro;
    public GameObject posicaoLivro;

    public void Update()
    {
        
    }
    public void fazAnimacao()
    {
        Livro.GetComponent<Animator>().Play("animaLivro");
       
    }

  
}
