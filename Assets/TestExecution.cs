using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestExecution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Start Method Called");
    }
    void Awake()
    {
        print("Awake Method Called");
    }
    
    void OnEnable()
    {
        print("Enable Method Called");
    }

    // Update is called once per frame
    void Update()
    {
        print("Update Method Called");
    }

    private void FixedUpdate()
    {
        print("FixedUpdate Method Called");
    }
}
