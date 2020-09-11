using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        RagdollBehavior ragdoll = other.gameObject.GetComponentInParent<RagdollBehavior>();
        if (ragdoll != null)
            ragdoll.RagdollOn = true;
    }
}
