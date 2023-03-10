using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip clip;
    [Min (0)]
    public float Volume;

    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _audio.PlayOneShot(clip);
    }

    private void OnDisable()
    {
        _audio.Stop();
    }
}
