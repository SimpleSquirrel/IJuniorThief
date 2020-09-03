using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private MovePlayer _move;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _move = GetComponent<MovePlayer>();
    }

    public void ChangeVisibility()
    {
        _spriteRenderer.sortingOrder *= -1;
    }
}
