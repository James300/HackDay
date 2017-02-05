using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalGameController : MonoBehaviour
{
    public ISelectable CurrentSelected { get; set; }

    void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {

    }

    public void SelectAlly(Action callback = null)
    {

    }

    public void SelectEnemy(Action callback = null)
    {
        if (callback != null)
        {
            callback();
        }
    }
}
