using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostraLivro : MonoBehaviour
{
    public GameObject Livro;
    public GameObject posicaoLivro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void mostraLivro()
    {
        Livro.gameObject.SetActive(true);
        Livro.transform.position = posicaoLivro.transform.position;

        Livro.transform.rotation = posicaoLivro.transform.rotation;
    }
}
