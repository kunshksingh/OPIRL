using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Input;



public class HandTracking : MonoBehaviour
{
    public GameObject joint;

    GameObject thumb;
    GameObject indexFinger;
    GameObject middleFinger;
    GameObject ringFinger;
    GameObject pinkyFinger;


    MixedRealityPose pose;


    void Start()
    {
        thumb = Instantiate(joint, this.transform);
        indexFinger = Instantiate(joint, this.transform);
        middleFinger = Instantiate(joint, this.transform);
        ringFinger = Instantiate(joint, this.transform);
        pinkyFinger = Instantiate(joint, this.transform);

    }


    void Update()
    {
        thumb.GetComponent<Renderer>().enabled = false;
        indexFinger.GetComponent<Renderer>().enabled = false;
        middleFinger.GetComponent<Renderer>().enabled = false;
        ringFinger.GetComponent<Renderer>().enabled = false;
        pinkyFinger.GetComponent<Renderer>().enabled = false;

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out pose))
        {
            thumb.GetComponent<Renderer>().enabled = true;
            thumb.transform.position = pose.Position;
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out pose))
        {
            indexFinger.GetComponent<Renderer>().enabled = true;
            indexFinger.transform.position = pose.Position;
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out pose))
        {
            middleFinger.GetComponent<Renderer>().enabled = true;
            middleFinger.transform.position = pose.Position;
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out pose))
        {
            ringFinger.GetComponent<Renderer>().enabled = true;
            ringFinger.transform.position = pose.Position;
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out pose))
        {
            pinkyFinger.GetComponent<Renderer>().enabled = true;
            pinkyFinger.transform.position = pose.Position;
        }
    }
}
