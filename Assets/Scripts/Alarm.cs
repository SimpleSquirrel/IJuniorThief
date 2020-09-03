using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    private AudioSource _audio;
    private Animator _animator;
    private bool _increaseVolume;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(_audio.enabled)
            SliderEffect();
    }

    public void TurnAlarm()
    {
        _audio.enabled = !_audio.enabled;
        _audio.volume = 0;
        _animator.enabled = !_animator.enabled;
        
    }

    public void SliderEffect()
    {
        if(_increaseVolume)
        {
            _audio.volume += Time.deltaTime;
            if (_audio.volume == 1)
            {
                _increaseVolume = false;
            }
        }
        else
        {
            _audio.volume -= Time.deltaTime;
            if (_audio.volume == 0)
            {
                _increaseVolume = true;
            }
        }
    }
}
