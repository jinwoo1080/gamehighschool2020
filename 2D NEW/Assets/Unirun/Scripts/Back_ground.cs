using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_ground : MonoBehaviour
{
    private void Update()
    {
        var collider = GetComponent<BoxCollider2D>();
        float width = collider.size.x;

        if(transform.position.x <= -width)
        {
            transform.position += Vector3.right * 2f * width;
        }
    }
}

