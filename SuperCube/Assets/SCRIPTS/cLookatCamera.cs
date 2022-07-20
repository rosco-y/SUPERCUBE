using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cLookatCamera : MonoBehaviour
{
    public Camera _camera;
    Vector3 _position;
    Quaternion _rotation;

    private void Start()
    {
        //_camera = Camera.main;
        _position = _camera.transform.position;
        _rotation = _camera.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //if (_position != _camera.transform.position || _rotation != _camera.transform.rotation)
        //{
            this.transform.LookAt(_camera.transform.position);
            this.transform.rotation = _camera.transform.rotation;
        //}
    }
}
