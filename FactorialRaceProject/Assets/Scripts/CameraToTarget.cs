using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    private readonly float speed = 5f;

    private void Start()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
    }

    private void Update()
    {
        Vector3 position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
    }
}
