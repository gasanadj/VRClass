using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using Unity.XR.CoreUtils;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private Transform targetPanelLocation;
    private XROrigin xrOrigin;

    private void Start()
    {
        xrOrigin = FindObjectOfType<XROrigin>();

        // Get the XR Simple Interactable component
        var interactable = GetComponent<XRSimpleInteractable>();
        if (interactable == null)
        {
            // Add it if it doesn't exist
            interactable = gameObject.AddComponent<XRSimpleInteractable>();
        }

        // Subscribe to the select event
        interactable.selectEntered.AddListener(OnButtonSelected);
    }

    private void OnButtonSelected(SelectEnterEventArgs args)
    {
        MoveToPanel();
    }

    public void MoveToPanel()
    {
        Debug.Log("Clicked");
        if (xrOrigin != null && targetPanelLocation != null)
        {
            xrOrigin.MoveCameraToWorldLocation(targetPanelLocation.position);
            xrOrigin.transform.rotation = targetPanelLocation.rotation;
        }
    }
}
