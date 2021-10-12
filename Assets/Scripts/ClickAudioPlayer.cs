using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAudioPlayer : MonoBehaviour
{
    public AudioSource _audiosource;

    private void Awake() {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable() {
        ClickScore.clicked += PlayAudio;
    }

    private void OnDisable() {
        ClickScore.clicked -= PlayAudio;
    }

    private void PlayAudio(){
        _audiosource.Play();
    }
}
