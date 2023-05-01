using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaserOpenToilets : MonoBehaviour
{
    [SerializeField] private CreatorBrush _creatorBrush;
    [SerializeField] private DrawHandler _drawHandler;
    [SerializeField] private ChooserToilet _chooserToilet;
    private int _countOfFreeToilets;
    public event Action OnReachEveryToilet;
    private void Awake()
    {
        _creatorBrush.OnCreateBrush += Subscribe;
        _countOfFreeToilets = _chooserToilet.Toilets.Count;
    }
    private void Subscribe()
    {
        _creatorBrush.CurrentBrush.OnSetUp += RemoveToilets;
    }
    private void RemoveToilets()
    {
        _countOfFreeToilets--;
        if (_countOfFreeToilets <= 0)
        {
            Debug.Log("REACH!");
            OnReachEveryToilet?.Invoke();
        }
        _creatorBrush.CurrentBrush.OnSetUp -= RemoveToilets;
    }

    private void OnDisable()
    {
        _creatorBrush.OnCreateBrush -= Subscribe;
    }
}
