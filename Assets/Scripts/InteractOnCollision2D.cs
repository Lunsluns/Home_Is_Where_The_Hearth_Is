﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class InteractOnCollision2D : MonoBehaviour
{
    public LayerMask layers;
    public UnityEvent OnCollision;

    void Reset()
    {
        layers = LayerMask.NameToLayer("Everything");
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        if (layers.Contains (collision.gameObject))
        {
            OnCollision.Invoke();
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "InteractionTrigger", false);
    }

}
