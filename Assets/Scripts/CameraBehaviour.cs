using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {

    public void SetCameraDistance()
    {
        GetComponent<Camera>().orthographicSize = 24 + (levelManager.playerCount / 1.8f);
    }
}
