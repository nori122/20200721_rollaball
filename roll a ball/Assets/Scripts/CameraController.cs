﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; //Unity内で修正できる
    private Vector3 offset; //script内で制御する
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
