﻿using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {

    public void SetCameraDistance()
    {
        GetComponent<Camera>().orthographicSize = 30 + (levelManager.playerCount / 4f);
    }
}
