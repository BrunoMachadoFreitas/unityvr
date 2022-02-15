using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class gameVariables : MonoBehaviour
{
    [SerializeField]
    [Range(0.0f, 100.0f)]
    private float points;

    public PostProcessVolume postProcessProfile;
    private ColorGrading _ColorGrading;
    private gameProgressControl gameProgressControl;
    public int incrementaProgresso = 0;

    public GameObject apresentaGameOver;


    public float Points   // property
    {
        get { return points; }   // get method
        set
        {
            if (value > 0) { 
               
                _ColorGrading.saturation.value = value * 2 - 100;
                
                gameProgressControl.MyOwnProgress = value;  
            }
            

            if (value <= 0)
            {
                apresentaGameOver.gameObject.SetActive(true);
                _ColorGrading.saturation.value = -100;
                StartCoroutine("func");
            }
            points = value;


           
        }
    }
    private void Start()
    {
 
        gameProgressControl = GetComponentInParent<gameProgressControl>();
        postProcessProfile.profile.TryGetSettings(out _ColorGrading);
        _ColorGrading.saturation.value = points * 2 - 100;
    }


    private void Update()
    {
        
       // 
    }

    public int progresso
    {
        get { return incrementaProgresso; }
        
    }

    IEnumerator func()
    {
        yield return new WaitForSecondsRealtime(5); //Wait 1 second
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
