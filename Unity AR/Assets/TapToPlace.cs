using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation.Samples;

public class TapToPlace : MonoBehaviour
{
    private GameObject Spawned_Object;
    public GameObject Object_prefab;
   
    PlaneDetectionController m_planeDetectionController;
    //Remove all reference points created
    public void RemoveAllReferencePoints()
    {
        foreach (var referencePoint in m_ReferencePoint)
        {
            m_ReferencePointManager.RemoveAnchor(referencePoint);
        }
        m_ReferencePoint.Clear();
    }


    void Awake()
    {
        m_RaycastManager = GetComponent<ARRaycastManager>();
        m_ReferencePointManager = GetComponent<ARAnchorManager>();
        m_PlaneManager = GetComponent<ARPlaneManager>();
        m_ReferencePoint = new List<ARAnchor>();
        m_planeDetectionController = GetComponent<PlaneDetectionController>();
    }


    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;
        return false;
    }

    void Update()
    {
      
       
        if (!TryGetTouchPosition(out Vector2 touchPosition))
            return;
        if (touchPosition.y > (Screen.height / 4))
        {
        /*    if (m_RaycastManager.Raycast(touchPosition, s_Hits, TrackableType.PlaneWithinPolygon))
            {
                // Raycast hits are sorted by distance, so the first one
                // will be the closest hit.
                var hitPose = s_Hits[0].pose;
                TrackableId planeId = s_Hits[0].trackableId; //get the ID of the plane hit by the raycast
                var referencePoint = m_ReferencePointManager.AttachAnchor(m_PlaneManager.GetPlane(planeId), hitPose);
                if (referencePoint != null)
                {
                    RemoveAllReferencePoints();
                    m_ReferencePoint.Add(referencePoint);
                }
                if (m_planeDetectionController.m_ARPlaneManager.enabled)
                {
                    m_planeDetectionController.TogglePlaneDetection();
                }
            }
        */
            if(m_RaycastManager.Raycast(touchPosition,s_Hits,TrackableType.PlaneWithinPolygon))
            {
                var hitpos = s_Hits[0].pose;
                if(Spawned_Object == null)
                {
                    Spawned_Object = Instantiate(Object_prefab, hitpos.position, hitpos.rotation);
                }
                else
                {
                    Spawned_Object.transform.position = hitpos.position;
                    Spawned_Object.transform.rotation = hitpos.rotation;
                }


                if (m_planeDetectionController.m_ARPlaneManager.enabled)
                {
                    m_planeDetectionController.TogglePlaneDetection();
                }
            }
        }
    }

    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

    ARRaycastManager m_RaycastManager;
    ARAnchorManager m_ReferencePointManager;
    List<ARAnchor> m_ReferencePoint; 
    ARPlaneManager m_PlaneManager;
   
    

}
