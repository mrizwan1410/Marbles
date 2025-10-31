using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    private GameObject player;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        rb.AddForce((player.transform.position - transform.position).normalized*speed);
    }
}
