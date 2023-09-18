using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.UIElements.UIR;

public class AudioPlayer : MonoBehaviour
{   
    private AudioSource audioSource;

    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        
    }

    /// <summary>
    /// Plays an Aduio clip
    /// </summary>
    public void PlayAudio()
    {
        audioSource.Play();
        Debug.Log("play!");
    }

    /// <summary>
    /// Pauses an audio clip
    /// </summary>
    public void PauseAudio()
    {
        audioSource.Pause();
    }
    
    
}
