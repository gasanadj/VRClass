using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateRectile : MonoBehaviour
{
    public InputActionProperty leftRectile;
    public InputActionProperty rightRectile;

    public GameObject left;
    //public GameObject right;

    public XRRayInteractor leftRay;
    public XRRayInteractor rightRay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber, out bool leftValid);
        bool isHoveringR = rightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber, out bool rightValid);
        left.SetActive(isHovering && leftRectile.action.ReadValue<float>() > 0.1f);
        //right.SetActive(isHoveringR && rightRectile.action.ReadValue<float>() > 0.1f);
    }
}
