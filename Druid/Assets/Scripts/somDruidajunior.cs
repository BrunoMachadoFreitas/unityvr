using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class somDruidajunior : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioClip[] audioClips1;
    public AudioClip[] audioClips2;
    public AudioClip[] audioClips3;
    public AudioClip[] audioClips4;
    public AudioSource audioSources;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AudioSource playSound(int id)
    {
        this.audioSources.clip = audioClips[id];
        this.audioSources.Play();

        return this.audioSources;
    }
}
