using System;
using System.Collections.Generic;
using UnityEngine;
public class StarterDrawingState : MonoBehaviour
{
    public event Action OnTryDrawing;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            OnTryDrawing?.Invoke();
        }
       
    }

}
