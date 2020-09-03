using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    private Alarm _alarm;
    private AudioSource _audio;
    private Animator _animator;

    private void Start()
    {
        _alarm = FindObjectOfType<Alarm>();
        _audio = _alarm.GetComponent<AudioSource>();
        _animator = _alarm.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.TryGetComponent<Player>(out Player player))
        {
            player.ChangeVisibility();

            _alarm.TurnAlarm();
            _audio.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            player.ChangeVisibility();

            _alarm.TurnAlarm();
        }
    }
}
