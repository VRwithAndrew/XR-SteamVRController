using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Valve.VR;

public class SteamVRBasedController : XRBaseController
{
    // SteamVR Tracking

    // SteamVR Input

    private void Start()
    {
        // Start SteamVR
    }

    protected override void UpdateTrackingInput(XRControllerState controllerState)
    {
        // Get position from pose action

        // Get rotation from position action
    }

    protected override void UpdateInput(XRControllerState controllerState)
    {
        // Reset all of the input values

        // Check select action, apply to controller

        // Check activate action, apply to controller

        // Check UI action, apply to controller
    }

    private void SetInteractionState(ref InteractionState interactionState, SteamVR_Action_Boolean_Source action)
    {
        // Pressed this frame

        // Released this frame

        // Is pressed
    }
}

