using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float smoothSpeed = 0.125f;
    [SerializeField] private Vector3 offset;

     
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void FixedUpdate()
    {
        try
        {
            Vector3 offsetedPosition = player.transform.position + offset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position, offsetedPosition, smoothSpeed);
            transform.position = smoothPosition;
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Player not found: " + ex.Message);
        }
    }
}
