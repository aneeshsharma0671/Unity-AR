using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectPlacementController : MonoBehaviour
{
    TapToPlace m_tapToPlace;
    public GameObject LockButton;
    public GameObject SizeButton;
    public GameObject SizeSlider;
    public GameObject previous_Text;
    public GameObject status_text;

    private void Awake()
    {
        m_tapToPlace = GetComponent<TapToPlace>();
    }
    public void toggleTaptoPlace()
    {
        m_tapToPlace.enabled = false;
        previous_Text.SetActive(false);
        status_text.SetActive(true);
        status_text.GetComponent<TMP_Text>().text = "Set Object Size";
        LockButton.SetActive(false);
        SizeButton.SetActive(true);
        SizeSlider.SetActive(true);

    }

    public void onSizeLock()
    {
        status_text.SetActive(false);
        SizeButton.SetActive(false);
        SizeSlider.SetActive(false);
    }
}
