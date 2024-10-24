using UnityEngine;
using UnityEngine.Audio;
[System.Serializable]
public class SoundSO 
{
    public string name;
    public AudioSource sourse;
    public AudioClip clip;
    public bool loop;
    public AudioMixerGroup group;

    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;
}
