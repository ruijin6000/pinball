using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour {

    public GameObject target;
    private Transform t;
    //public float scale = 4f;
    // Use this for initialization

    //private void Awake()
    //{
    //    var cam = GetComponent<Camera>();
    //    cam.orthographicSize = (Screen.height /2f)/scale;
    //}

    void Start()
    {
        t = target.transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (target != null)
        {
            transform.position = new Vector3(t.position.x, t.position.y, transform.position.z);
        }
    }
}
