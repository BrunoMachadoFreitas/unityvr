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
                        audioSources.clip = audioClips[2];
                        audioSources.Play();
                        //audioSources.PlayOneShot(audioClips[2]);
                        
                        break;
                    case FasesDoJogo.tirar:
                        audioSources.Stop();
                        audioSources.clip = audioClips[3];
                        audioSources.Play();
                        break;
                    case FasesDoJogo.plantar:
                        audioSources.Stop();
                        audioSources.clip = audioClips[4];
                        audioSources.Play();
                        cod_FinalScene.AppearOneByOne();
                        break;
                    case FasesDoJogo.meio:
                        audioSources.Stop();
                        audioSources.clip = audioClips[3];
                        audioSources.Play();
                        break;
                    case FasesDoJogo.fim:
                        audioSources.Stop();
                        audioSources.clip = audioClips[4];
                        audioSources.Play();
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
        audioSources.clip = audioClips[1];
        audioSources.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
