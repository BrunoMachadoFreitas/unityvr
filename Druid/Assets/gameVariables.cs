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



    public float Points   // property
    {
        get { return points; }   // get method
        set { _ColorGrading.saturation.value = value * 2 - 100; ; points = value; }  // set method
    }
    private void Start()
    {
        postProcessProfile.profile.TryGetSettings(out _ColorGrading);
    }


    private void Update()
    {
        //points += 1;
        _ColorGrading.saturation.value = points*2 - 100;
    }
}
