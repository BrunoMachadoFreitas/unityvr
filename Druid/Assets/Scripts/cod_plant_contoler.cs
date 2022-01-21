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

    // Start is called before the first frame update

    public void RemovePlant()
    {
        if (this.gameObject.GetComponent<mostraInfoPlanta>().podeTirar)
        {
            if (plantType == PlantType.good)
            {
                GetComponentInChildren<TrailRenderer>().startColor = Color.red;
            audioSource.PlayOneShot(audioClips[1]);
        }
            else
            {
            audioSource.PlayOneShot(audioClips[0]);
          
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

    void Start()
    {

        m_Renderer = GetComponent<Renderer>();

       

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
                this.gameObject.transform.localPosition += Vector3.up * 1.5f;
                this.gameObject.transform.localPosition += Vector3.forward * 0.5f;
                
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
