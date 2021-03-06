﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBG : MonoBehaviour
{
    SpriteRenderer sr;
    float length;
    public float speed;
    float halfSize;
    float returnPoint;
    Vector2 size;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        startPos = transform.position;
        size = sr.size;
        halfSize = size.x / 2;
        returnPoint = startPos.x - size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x - speed, transform.position.y);
        if (transform.position.x <= startPos.x - 38.4) {
            transform.position = startPos;
        }
    }
}
