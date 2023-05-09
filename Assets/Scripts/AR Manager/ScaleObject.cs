using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    public GameObject _object;

    private bool zoomIn;
    private bool zoomOut;

    public float Scale = 0.03f;

    void Update(){
        if (zoomIn)
        {
            _object.transform.localScale += new Vector3(Scale, Scale, Scale);
        }

        if (zoomOut)
        {
            _object.transform.localScale -= new Vector3(Scale, Scale, Scale);
        }
        
    }

    public void OnPressZoomIn()
    {
        zoomIn = true;
    }

    public void OnReleaseZoomIn()
    {
        zoomIn = false;
    }

    public void OnPressZoomOut()
    {
        zoomOut = true;
    }

    public void OnReleaseZoomOut()
    {
        zoomOut = false;
    }
}
