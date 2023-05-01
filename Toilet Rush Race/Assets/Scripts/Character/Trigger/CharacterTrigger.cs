using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTrigger : MonoBehaviour
{
    public event Action OnTriggerCharacter;
    public event Action OnTriggerToilet;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Character>())
        {
            OnTriggerCharacter?.Invoke();
        }
        if (collision.GetComponent<Toilet>())
        {
            OnTriggerToilet?.Invoke();
        }
    }
}
