using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawHandler : MonoBehaviour
{
    [SerializeField] private CreatorBrush _creatorBrush;
    public event Action OnDraw;
    public event Action OnStopDrawing;
    private bool _canDraw = false;
    private void Awake()
    {
        _creatorBrush.OnCreateBrush += AllowDrawing;
    }
    private void AllowDrawing()
    {
        _canDraw = true;
    }
    private void Update()
    {
        if (_canDraw)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                OnDraw?.Invoke();
            }
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                Debug.Log("GET KEY UP!");
                OnStopDrawing?.Invoke();
                _canDraw = false;
            }

        }
    }
    private void OnDisable()
    {
        _creatorBrush.OnCreateBrush -= AllowDrawing;
    }
}
