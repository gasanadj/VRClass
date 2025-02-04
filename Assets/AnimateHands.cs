using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class AnimateHands : MonoBehaviour
{
    public InputActionProperty leftActivate;
    public InputActionProperty grab;
    public Animator handAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float lValue = leftActivate.action.ReadValue<float>();
        float value = grab.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", lValue);
        handAnimator.SetFloat("Grip", value);

    }
}
