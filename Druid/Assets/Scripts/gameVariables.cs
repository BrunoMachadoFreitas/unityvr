using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class gameVariables : MonoBehaviour
{
    [SerializeField]
    [Range(0.0f, 100.0f)]
    private float points;

    public PostProcessVolume postProcessProfile;
    private ColorGrading _ColorGrading;
    private gameProgressControl gameProgressControl;
    public int incrementaProgresso = 0;


    public float Points   // property
    {
        get { return points; }   // get method
        set { _ColorGrading.saturation.value = value * 2 - 100; gameProgressControl.MyOwnProgress = value; points = value; }  // set method
    }
    private void Start()
    {
        gameProgressControl = GetComponentInParent<gameProgressControl>();
        postProcessProfile.profile.TryGetSettings(out _ColorGrading);
    }


    private void Update()
    {
        
        _ColorGrading.saturation.value = points*2 - 100;
    }

    public int progresso
    {
        get { return incrementaProgresso; }
        
    }

}
