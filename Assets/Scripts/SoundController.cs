using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource audioSource; // Drag and drop an AudioSource component onto this variable in the Inspector
    public AudioClip aproxSound; 
    public AudioClip startSound; 
    public AudioClip angerSound;
    public AudioClip randomSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Call this function to play the audio clip
    public void PlayAproxSound()
    {
        audioSource.PlayOneShot(aproxSound); // Play the audio clip once using the audio source
    }

    public void PlayStartSound()
    {
        audioSource.PlayOneShot(startSound); // Play the audio clip once using the audio source
    }

    public void PlayRandomSound()
    {
        audioSource.PlayOneShot(randomSound); // Play the audio clip once using the audio source
    }

    public void PlayAngerSound()
    {
        audioSource.PlayOneShot(angerSound); // Play the audio clip once using the audio source
    }
}
