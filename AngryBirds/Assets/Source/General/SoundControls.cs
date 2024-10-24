using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundControls : MonoBehaviour
{

    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private Slider _soundControl;
    [SerializeField] private Button _soundButton;
    [SerializeField] private Sprite _soundOn;
    [SerializeField] private Sprite _soundOff;

    private bool _isSoundOn = true;
    private float _volume;
    private float _zeroVolume = -80;
    
    
    private void Start()
    {
        _volume = PlayerPrefs.GetFloat("GameVolume");
        _soundControl.onValueChanged.AddListener(ControlVolume);
        _soundControl.value = Mathf.Pow(10f, _volume / 20);
    }
    private void SetVolume()
    {
        _mixer.SetFloat("Master", _volume);
        PlayerPrefs.SetFloat("GameVolume",_volume);
       
    }
    public void PressButton()
    {
        
        if (_isSoundOn)
        {
            _soundButton.image.sprite = _soundOff;
            _mixer.SetFloat("Master", _zeroVolume);
           
            _isSoundOn = false;
            
        } else
        {
            _soundButton.image.sprite = _soundOn;
           
          
            _isSoundOn = true;
            SetVolume();
        }
    } 
    public void ControlVolume(float volume)
    {
        _volume = Mathf.Log10(volume) * 20;
        SetVolume();
    }
    
}
