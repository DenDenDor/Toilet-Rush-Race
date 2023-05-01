using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetterBrushBaseline : MonoBehaviour
{
    [SerializeField] private CreatorBrush _creatorBrush;
    [SerializeField] private SelecterMaterialForBrush _selecterMaterialForBrush;
    [SerializeField] private Camera _camera;
    private void Awake()
    {
        _creatorBrush.OnCreateBrush += CreateBrush;
    }
    private void CreateBrush()
    {
        Vector2 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        _creatorBrush.CurrentBrush.SetMaterial(_selecterMaterialForBrush.ReturnCurrentMaterial());
        _creatorBrush.CurrentBrush.AddPoint(mousePosition);
        _creatorBrush.CurrentBrush.AddPoint(mousePosition);
    }
    private void OnDisable()
    {
        _creatorBrush.OnCreateBrush -= CreateBrush;
    }
}
