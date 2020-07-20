using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float m_Speed = 5f;


    private void Update()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        rigidbody.AddForce(new Vector2(xAxis, yAxis) * m_Speed);
    }
}
