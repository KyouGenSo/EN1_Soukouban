using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // �����܂łɂ����鎞��
    private float timeTaken = 0.2f;
    // �o�ߎ���
    private float timeElapsed = 0;
    // �ړI�n
    private Vector3 destination;
    // �ړ���
    private Vector3 origin;

    public void MoveTo(Vector3 newDestination)
    {
        timeElapsed = 0;
        origin = destination;
        transform.position = origin;
        destination = newDestination;
    }

    private void Start()
    {
        destination = transform.position;
        origin = destination;
    }

    private void Update()
    {
        if(origin == destination)
        {
            return;
        }

        timeElapsed += Time.deltaTime;

        float timeRate = timeElapsed / timeTaken;

        if(timeRate > 1)
        {
            timeRate = 1;
        }

        transform.position = Vector3.Lerp(origin, destination, timeRate);
    }
}
