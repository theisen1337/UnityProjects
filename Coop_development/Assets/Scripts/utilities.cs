using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class utilities
{
    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 worldPosition;
        worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPosition.z = 0f;
        return worldPosition;
    }
}
