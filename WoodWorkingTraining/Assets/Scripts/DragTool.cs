using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controls clicking and dragging tools using left mouse click
public class DragTool : MonoBehaviour
{
    private Vector3 toolOffset;
    private float zCoordinate;

    void OnMouseDown()
    {
        zCoordinate = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        // Stores offset of object in relation to mouse
        toolOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        // Gets position of the mouse point within the Input class, converts pixel coordinates to world coordinates
        Vector3 mousePoint = Input.mousePosition;

        // Collects z coordinate data on screen
        mousePoint.z = zCoordinate;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    } 

    void OnMouseDrag()
    {
        // Returns this vector as result of calculating mouse position on screen
        transform.position = GetMouseWorldPos() + toolOffset;
    }
}
