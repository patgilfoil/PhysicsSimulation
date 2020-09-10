using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsObject : MonoBehaviour
{
    public Material awakeMaterial = null;
    public Material asleepMaterial = null;

    private Rigidbody _rigidbody = null;
    private Material _material = null;

    private bool wasSleeping = false;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _material = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(_rigidbody.IsSleeping() && !wasSleeping && asleepMaterial != null)
        {
            wasSleeping = true;
            _material = asleepMaterial;
        }

        if (!_rigidbody.IsSleeping() && wasSleeping && awakeMaterial != null)
        {
            wasSleeping = false;
            _material = awakeMaterial;
        }
    }
}
