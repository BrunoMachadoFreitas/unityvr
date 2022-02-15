using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostraLivro : MonoBehaviour
{
    public Transform Livro;
    public Transform posicaoLivro;
    public GameObject LivroObj;
    public GameObject livroUi;
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
        livroUi.gameObject.SetActive(false);
        LivroObj.gameObject.SetActive(true);
        Livro.transform.position = posicaoLivro.transform.position;

        Livro.parent = posicaoLivro.parent;
    }
}
