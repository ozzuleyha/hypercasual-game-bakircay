using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PathCreation;

public class MovementTrain : MonoBehaviour
{
    public PathCreator pathCreator;
    public EndOfPathInstruction endOfPathInstruction;
    public float speed = 0.05f;
    public float startTime = 0;
    public GameObject StopButton;
    public GameObject StartButton;
    float timeTravelled = 0;

    void Start()
    {
        if (pathCreator != null)
        {
            pathCreator.pathUpdated += OnPathChanged;
            timeTravelled = startTime;
        }
    }

    void Update()
    {
        if (pathCreator != null)
        {
            timeTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtTime(timeTravelled, endOfPathInstruction);
            transform.rotation = pathCreator.path.GetRotation(timeTravelled, endOfPathInstruction);
        }
      
    }

    void OnPathChanged()
    {
    }
    public float GetCurrentTimeTravelled()
    {
        return timeTravelled;
    }

    public void StopMovement()
    {
        speed = 0;
    }

    public void StopClick()
    {
        speed= 0;
        StopButton.SetActive(false);
        StartButton.SetActive(true);

    }
    public void StartClick()
    {
        speed = 0.05f;
        StopButton.SetActive(true);
        StartButton.SetActive(false);
    }
}
