using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VagoonMovement : MonoBehaviour
{
    public MovementTrain train;
    public float offsetBetweenFront = -0.035f;

    // Update is called once per frame
    void Update()
    {
        if (train == null)
            return;

        var timeTravelled = train.GetCurrentTimeTravelled() + offsetBetweenFront;
        transform.position = train.pathCreator.path.GetPointAtTime(timeTravelled, train.endOfPathInstruction);
        transform.rotation = train.pathCreator.path.GetRotation(timeTravelled, train.endOfPathInstruction);

    }
}
