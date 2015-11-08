using UnityEngine;
using System.Collections;

public class ControlBalls : MonoBehaviour {

    private Vector3 mousePosition;
    public float moveSpeed = 0.5f;

    void OnMouseDrag()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

	void Update () 
    {
    
	}
}
