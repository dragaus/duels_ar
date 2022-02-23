using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int Damage { get => m_Damage; }
    [SerializeField] int m_Damage = 1;

    [SerializeField] float m_Velocity = 1f;
    [SerializeField] float m_MaxLive = 2;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, m_MaxLive);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * m_Velocity * Vector3.forward);
    }
}
