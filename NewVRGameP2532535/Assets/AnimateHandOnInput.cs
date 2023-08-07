using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAmimator; 

    
    void Start()
    {
        
    }

    
    void Update()
    {
       float triggerValue = pinchAnimationAction.action.ReadValue<float>();
       handAmimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAmimator.SetFloat("Grip", gripValue);
    }
}
