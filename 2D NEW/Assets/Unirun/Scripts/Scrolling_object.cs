using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling_object : MonoBehaviour
{
    public float m_Speed = 5f;

    private void Update()
    {
        transform.position += Vector3.left * m_Speed * Time.deltaTime;
    }
}
    