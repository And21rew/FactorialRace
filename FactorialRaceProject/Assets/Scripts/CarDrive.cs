using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrive : MonoBehaviour
{
    [SerializeField] private float speed;
    Rigidbody2D rb;

    [SerializeField] private GameObject raceStatus;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;

        raceStatus.GetComponent<StartEndRace>().StartRace();
    }
    private void FixedUpdate()
    {
        if (raceStatus.GetComponent<StartEndRace>().canGo)
            transform.Translate(speed * Time.deltaTime * Vector3.up);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("FinishLine"))
        {
            raceStatus.GetComponent<StartEndRace>().EndRace(this.gameObject);
        }
    }
}
