using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Vector3 GetMouseWorldPosition()
    {
        Vector3 result = Input.mousePosition;

        result.z = Camera.main.WorldToScreenPoint(transform.position).z;

        result = Camera.main.ScreenToWorldPoint(result);

        return result;
    }

     void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = GetMouseWorldPosition();

            Collider2D collider2D = Physics2D.OverlapPoint(mousePos);
            if (collider2D != null)
            {
                if (collider2D.TryGetComponent(out IInteract interact))
                {
                    interact.Interact();
                }
            }
        }
    }
}
