﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float smoothspeed = 0.25f;
	public Vector3 offset;

    private Transform target = null;
    private bool hasTarget = false;

    void LateUpdate()
    {
        if (hasTarget)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
            transform.position = smoothedPosition;
        }
           
	}

    public void setTarget(Transform target)
    {
        this.target = target;
        hasTarget = true;
    }
}
