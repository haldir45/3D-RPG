﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorDebugger : MonoBehaviour
{
    CameraRaycaster cameraRaycaster;
    // Start is called before the first frame update
    void Start()
    {
        cameraRaycaster = GetComponent<CameraRaycaster>();
    }

    // Update is called once per frame
    void Update()
    {
        print(cameraRaycaster.LayerHit);
    }
}
