using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacementController : MonoBehaviour
{
    TapToPlace m_tapToPlace;

    private void Awake()
    {
        m_tapToPlace = GetComponent<TapToPlace>();
    }
    public void toggleTaptoPlace()
    {
        m_tapToPlace.enabled = !m_tapToPlace.enabled;
    }
}
