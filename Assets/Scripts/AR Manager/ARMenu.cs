using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARMenu : MonoBehaviour
{
    [SerializeField] private GameObject arMenuPanel;

    public void ARMenuPanel()
    {
        arMenuPanel.SetActive(true);
    }

    public void ARMenuPanelClose()
    {
        arMenuPanel.SetActive(false);
    }
}
