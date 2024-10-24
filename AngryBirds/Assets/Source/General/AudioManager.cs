using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public SoundSO[] sounds;

   

    void Awake()
    {

        

        

        foreach (SoundSO s in sounds)
        {
            s.sourse = gameObject.AddComponent<AudioSource>();
            s.sourse.clip = s.clip;

            s.sourse.volume = s.volume;
            s.sourse.pitch = s.pitch;
            s.sourse.loop = s.loop;
            s.sourse.outputAudioMixerGroup = s.group;
        }
        Play("MainTheme");
    }
    public void Play(string name)
    {

        SoundSO s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.sourse.Play();
    }
}
