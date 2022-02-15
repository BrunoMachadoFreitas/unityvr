using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PlantType
{
    good,
    bad,
    neutral
}

public enum PlantsName
{
    Noveleiro,
    Pinheiro_Bravo,
    Cronalheira,
    Hortência,
    Àrove_do_incenso,
    Acácia
}
public class cod_plant_contoler : MonoBehaviour
{
    public PlantType plantType;
    public PlantsName plantName;
    public Texture[] textures;
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    Renderer m_Renderer;
    public GameObject placeholder;
    public Transform aguentadorPlantas;
    public float x, y, z;
    public GameObject variavelPostProcess;
    public GameObject passaros;
    public int nmrPlantas = 0;
    public GameObject animal2;
    public GameObject animal3;
    public GameObject animal4;
    public int progresso = 0;
    public bool tirouPlanta = false;
    public Text text;
    public Text text1;
    public Text text2; 
    public Text text3;
    // Start is called before the first frame update

    public void RemovePlant()
    {
        if (this.gameObject.GetComponent<mostraInfoPlanta>().podeTirar)
        {
            if (plantType == PlantType.good)
            {
                GetComponentInChildren<TrailRenderer>().startColor = Color.red;
                audioSource.PlayOneShot(audioClips[1]);
                variavelPostProcess.GetComponent<gameVariables>().incrementaProgresso--;
                variavelPostProcess.GetComponent<gameVariables>().Points -= progresso;
                tirouPlanta = true;
            }
            else
            {
                tirouPlanta = true;
                audioSource.PlayOneShot(audioClips[0]);
                variavelPostProcess.GetComponent<gameVariables>().Points += progresso;
                variavelPostProcess.GetComponent<gameVariables>().incrementaProgresso++;
            }

            if(variavelPostProcess.GetComponent<gameVariables>().incrementaProgresso == 1)
            {
                passaros.gameObject.SetActive(true);
            } 
            if(variavelPostProcess.GetComponent<gameVariables>().incrementaProgresso == 2)
            {
                animal2.gameObject.SetActive(true);
            }
            if (variavelPostProcess.GetComponent<gameVariables>().incrementaProgresso == 3)
            {
                animal3.gameObject.SetActive(true);
            }
            if (variavelPostProcess.GetComponent<gameVariables>().incrementaProgresso == 4)
            {
                animal4.gameObject.SetActive(true);
            }


            LeanTween.rotateY(this.gameObject, 300 * 5, 1).setOnComplete(() =>
            {
                LeanTween.moveY(this.gameObject, 10, 2).setEaseInBounce().setOnComplete(() =>
                {
                    this.gameObject.SetActive(false);
                });
            });
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }

    }
    private void Update()
    {
       
    }

    void Awake()
    {

        m_Renderer = GetComponent<Renderer>();
        progresso = (100 / nmrPlantas);



        switch (plantName)
        {
            case PlantsName.Noveleiro:
                plantType = PlantType.good;
                m_Renderer.material.SetTexture("_MainTex", textures[0]);
                this.gameObject.LeanScaleY(2, 2);
                this.gameObject.LeanScaleZ(2, 3);

                
                this.gameObject.transform.localPosition += Vector3.up * 1.5f;
                this.gameObject.transform.localPosition += Vector3.forward * 0.5f;

                text1.text = " Forma: Esfera irregular ";
                text2.text = " Cor de flor: Branca ";
                text3.text = " Tipo de planta: Arbusto ";

                break;


            case PlantsName.Pinheiro_Bravo:
                plantType = PlantType.good;
                m_Renderer.material.SetTexture("_MainTex", textures[1]);
              
                
                //this.transform.SetParent(aguentadorPlantas);
               
             
               // this.gameObject.transform.localPosition = new Vector3(0,GetComponent<MeshFilter>().mesh.bounds.extents.y,0);


                placeholder.GetComponentInChildren<Light>().spotAngle = 125;
                placeholder.GetComponentInChildren<Light>().intensity = 15;

                text1.text = " Folhas: Agudas ";
                text2.text = " Cor de flor: Laranja ";
                text3.text = " Tipo de planta: árvore  ";
                break;
            case PlantsName.Cronalheira:
                plantType = PlantType.good;
                m_Renderer.material.SetTexture("_MainTex", textures[2]);

                
               
                text1.text = " Folhas: Caducas ";
                text2.text = " Cor de Fruto: Vermelho ";
                text3.text = " Tipo de planta: Pequena árvore  ";
                break;
            case PlantsName.Hortência:
                plantType = PlantType.bad;
                m_Renderer.material.SetTexture("_MainTex", textures[3]);

            
              

                text1.text = " Forma: Bola ";
                text2.text = " Cor de flor: Branco , azul ou rosa ";
                text3.text = " Tipo de planta: Arbusto ";

                break;
            case PlantsName.Àrove_do_incenso:
                m_Renderer.material.SetTexture("_MainTex", textures[4]);
                plantType = PlantType.bad;

              
               

                text1.text = " Folhas: Folhas em Pico ";
                text2.text = " Cor de Fruto: Laranja";
                text3.text = " Tipo de planta: pequena árvore ";
                break;
            case PlantsName.Acácia:
                m_Renderer.material.SetTexture("_MainTex", textures[5]);
                plantType = PlantType.bad;

                                
               

                text1.text = " Folhas: Em Foice ";
                text2.text = " Cor de flor: amarela ";
                text3.text = " Tipo de planta: árvore ";
                break;

            default:
                break;
        }
    }


}
