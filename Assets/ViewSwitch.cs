using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ViewSwitch : MonoBehaviour
{
    public Camera cam;
    public GameObject arVolume;

    // Start is called before the first frame update
    void Start()
    {
        cam.GetComponent<Camera>();
        ShowNormalCamera();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButton("fire1"))
        {
            ShowARCamera();
        }

        else
            ShowNormalCamera();
    }

    private void ShowARCamera()
    {
        cam.cullingMask = ~(1 << LayerMask.NameToLayer("NormalContent"));
        arVolume.SetActive(true);
    }

    private void ShowNormalCamera()
    {
        cam.cullingMask = ~(1 << LayerMask.NameToLayer("ARContent"));
        arVolume.SetActive(false);
    }
}
