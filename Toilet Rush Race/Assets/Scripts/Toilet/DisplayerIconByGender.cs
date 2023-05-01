using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayerIconByGender : MonoBehaviour
{
    [SerializeField] private List<Sprite> _sprites;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Toilet _toilet;
    private void Awake()
    {
        _spriteRenderer.sprite = _sprites[(int) _toilet.Gender];
    }
}
