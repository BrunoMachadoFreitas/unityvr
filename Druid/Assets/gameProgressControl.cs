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
    
    
    public FasesDoJogo faseActual = FasesDoJogo.Inicio;
    public cod_move_around_Player druida;
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
                        druida.audioSources.clip = druida.audioClips[2];
                        druida.audioSources.Play();
                        //audioSources.PlayOneShot(audioClips[2]);
                        
                        break;
                    case FasesDoJogo.tirar:
                        druida.spinAround();
                        druida.audioSources.Stop();
                        druida.audioSources.clip = druida.audioClips[3];
                        druida.audioSources.Play();
                        break;
                    case FasesDoJogo.plantar:
                        druida.audioSources.Stop();
                        druida.audioSources.clip = druida.audioClips[4];
                        druida.audioSources.Play();
                        cod_FinalScene.AppearOneByOne();
                        break;
                    case FasesDoJogo.meio:
                        druida.audioSources.Stop();
                        druida.audioSources.clip = druida.audioClips[3];
                        druida.audioSources.Play();
                        break;
                    case FasesDoJogo.fim:
                        druida.audioSources.Stop();
                        druida.audioSources.clip = druida.audioClips[4];
                        druida.audioSources.Play();
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
        druida.audioSources.clip = druida.audioClips[1];
        druida.audioSources.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
