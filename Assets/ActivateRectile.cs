using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateRectile : MonoBehaviour
{
    public InputActionProperty leftRectile;
    public InputActionProperty rightRectile;

    public GameObject left;
    public GameObject right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        left.SetActive(leftRectile.action.ReadValue<float>() > 0.1f);
        right.SetActive(rightRectile.action.ReadValue<float>() > 0.1f);
    }
}
