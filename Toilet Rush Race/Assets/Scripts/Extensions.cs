using System;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    public static T GetNextElement<T>(this List<T> list, T element)
    {
        if (list.Contains(element) == false || list.IsListEmpty())
        {
            throw new InvalidOperationException();
        }
        T nextElement;
        int index = list.IndexOf(element);
        if (index >= list.Count)
        {
            nextElement = list[0];
        }
        else
        {
            nextElement = list[index++];
        }
        return nextElement;
    }
    public static bool IsListEmpty<T>(this List<T> list) => list.Count == 0;
}
