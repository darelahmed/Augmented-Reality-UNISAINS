using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    public GameObject _object;

    private bool zoomIn;
    private bool zoomOut;

    //object scale speed
    public float Scale = 0.03f;

    // Update is called once per frame
    void Update(){
        if (zoomIn)
        {
            //make a bigger object
            _object.transform.localScale += new Vector3(Scale, Scale, Scale);
        }

        if (zoomOut)
        {
            //make a small object
            _object.transform.localScale -= new Vector3(Scale, Scale, Scale);
        }
        
    }

    //Make object scaled big
    public void OnPressZoomIn()
    {
        zoomIn = true;
    }

    public void OnReleaseZoomIn()
    {
        zoomIn = false;
    }

    //Make object scaled small
    public void OnPressZoomOut()
    {
        zoomOut = true;
    }

    public void OnReleaseZoomOut()
    {
        zoomOut = false;
    }
}
