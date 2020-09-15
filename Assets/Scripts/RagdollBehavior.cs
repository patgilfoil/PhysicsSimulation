using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CharacterController))]
public class RagdollBehavior : MonoBehaviour
{
    private Animator _animator = null;
    private CharacterController _controller = null;
    public List<Rigidbody> rigidbodies = new List<Rigidbody>();

    public bool RagdollEnabled
    {
        get { return !_animator.enabled; }
        set
        {
            _animator.enabled = !value;
            _controller.enabled = !value;
            foreach (Rigidbody r in rigidbodies)
                r.isKinematic = !value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _controller = GetComponent<CharacterController>();

        foreach (Rigidbody r in rigidbodies)
            r.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
