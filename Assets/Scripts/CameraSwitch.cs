using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera cam1, cam2;
    
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
        }
    }
}
