using System;
using UnityEngine.Audio;
using UnityEngine;

public class audiomanager : MonoBehaviour
{

    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.src = gameObject.AddComponent<AudioSource>();
            s.src.clip = s.clip;
            s.src.volume = s.volume;
        }
    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.src.Play();
    }
}
