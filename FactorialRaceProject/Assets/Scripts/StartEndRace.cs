using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEndRace : MonoBehaviour
{
    private readonly float timeToStart = 3f;
    private readonly float timeToEnd = 1f;
    public bool canGo = false;

    public void StartRace()
    {
        StartCoroutine(StartRaceCoroutine());
    }

    public void EndRace(GameObject car)
    {
        StartCoroutine(EndRaceCoroutine(car));
    }

    IEnumerator StartRaceCoroutine()
    {
        yield return new WaitForSeconds(timeToStart);
        canGo = true;
    }

    IEnumerator EndRaceCoroutine(GameObject car)
    {
        yield return new WaitForSeconds(timeToEnd);
        car.SetActive(false);
    }
}
