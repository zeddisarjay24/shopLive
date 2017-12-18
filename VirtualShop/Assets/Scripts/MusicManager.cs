using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip audioClip;
    public Slider audioVolume;

	// Use this for initialization
	void Start () {
        audioVolume.value = audioSource.volume;
        audioSource.clip = audioClip;
        audioSource.Play();
	}

    public void adjustVolume() {
        audioSource.volume = audioVolume.value;
    }
}
