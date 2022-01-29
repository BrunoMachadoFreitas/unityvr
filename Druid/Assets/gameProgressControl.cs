using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FasesDoJogo
{
    Inicio =0,
    instrucao = 1,
    tirar =2,
    plantar = 3,
    meio = 4,
    fim = 5

}

public class gameProgressControl : MonoBehaviour
{
    public AudioSource audioSources;
    public AudioClip[] audioClips;
    public FasesDoJogo faseActual = FasesDoJogo.Inicio;

    public Cod_FinalScene cod_FinalScene;

    private float myOwnProgress; //same as progess but doesnt go back
    public float MyOwnProgress  // property
    {
        get { return myOwnProgress; }   // get method
        set { 

            if (value > myOwnProgress) {
                faseActual = (FasesDoJogo)((int)faseActual + 1);

                switch (faseActual)
                {
                    case FasesDoJogo.Inicio:
                        break;
                    case FasesDoJogo.instrucao:
                        audioSources.PlayOneShot(audioClips[1]);
                        cod_FinalScene.AppearOneByOne();
                        break;
                    case FasesDoJogo.tirar:
                        audioSources.PlayOneShot(audioClips[1]);
                        break;
                    case FasesDoJogo.plantar:
                        audioSources.PlayOneShot(audioClips[2]);
                        break;
                    case FasesDoJogo.meio:
                        audioSources.PlayOneShot(audioClips[3]);
                        break;
                    case FasesDoJogo.fim:
                        audioSources.PlayOneShot(audioClips[4]);
                        cod_FinalScene.AppearOneByOne();
                        break;
                    default:
                        break;
                }


                myOwnProgress = value; }; }  // set method
    }

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
