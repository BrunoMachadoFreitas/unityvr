using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private PlantType plantType;
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
            }
            else
            {
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
                animal2.gameObject.SetActive(true);
            }


            LeanTween.rotateY(this.gameObject, 300 * 5, 1).setOnComplete(() =>
            {
                LeanTween.moveY(this.gameObject, 10, 2).setEaseInBounce().setOnComplete(() =>
                {
                    this.gameObject.SetActive(false);
                });
            });

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

                this.gameObject.transform.localScale *= 3;
                this.gameObject.transform.localPosition += Vector3.up * 1.5f;
                this.gameObject.transform.localPosition += Vector3.forward * 0.5f;

                break;
            case PlantsName.Pinheiro_Bravo:
                plantType = PlantType.good;
                m_Renderer.material.SetTexture("_MainTex", textures[1]);
              
                this.gameObject.transform.localScale *= 3;
                //this.transform.SetParent(aguentadorPlantas);
                this.gameObject.transform.position += new Vector3(-0.0002f, 0.0039f, 0.0416f);
             
               // this.gameObject.transform.localPosition = new Vector3(0,GetComponent<MeshFilter>().mesh.bounds.extents.y,0);


                placeholder.GetComponentInChildren<Light>().spotAngle = 125;
                placeholder.GetComponentInChildren<Light>().intensity = 15;
                break;
            case PlantsName.Cronalheira:
                plantType = PlantType.good;
                m_Renderer.material.SetTexture("_MainTex", textures[2]);

                this.gameObject.transform.localScale *= 3;
                this.gameObject.transform.localPosition += Vector3.up * 1.5f;
                this.gameObject.transform.localPosition += Vector3.forward * 0.5f;

                break;
            case PlantsName.Hortência:
                plantType = PlantType.bad;
                m_Renderer.material.SetTexture("_MainTex", textures[3]);

                this.gameObject.transform.localScale *= 3;
                this.gameObject.transform.localPosition += Vector3.up * 1.5f;
                this.gameObject.transform.localPosition += Vector3.forward * 0.5f;
                break;
            case PlantsName.Àrove_do_incenso:
                m_Renderer.material.SetTexture("_MainTex", textures[4]);
                plantType = PlantType.bad;

                this.gameObject.transform.localScale *= 3;
                this.gameObject.transform.localPosition += Vector3.up * 1.5f;
                this.gameObject.transform.localPosition += Vector3.forward * 0.5f;
                break;
            case PlantsName.Acácia:
                m_Renderer.material.SetTexture("_MainTex", textures[5]);
                plantType = PlantType.bad;

                                this.gameObject.transform.localScale *= 3;
                this.gameObject.transform.localPosition += Vector3.up * 1.5f;
                this.gameObject.transform.localPosition += Vector3.forward * 0.5f;
                break;

            default:
                break;
        }
    }


}
