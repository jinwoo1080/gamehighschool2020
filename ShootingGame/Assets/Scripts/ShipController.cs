using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float m_Speed = 5f;

    public Bullet m_BulletPrefab;
    public float m_AttackDelay = 0.5f;
    public float m_AttackCooldown = 0f;

    public Transform[] m_FireMuzzles;

    private void Update()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        //rigidbody.AddForce(new Vector2(xAxis, yAxis) * m_Speed);
        transform.position += new Vector3(xAxis, yAxis, 0) * m_Speed * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.Space) && m_AttackCooldown <= 0)
        {
            foreach (var FireMuzzle in m_FireMuzzles)
            {
                var bullet = Instantiate(m_BulletPrefab, FireMuzzle.position, FireMuzzle.rotation);
            }
            m_AttackCooldown = m_AttackDelay;
        }
        m_AttackCooldown -= Time.deltaTime;
    }

}
