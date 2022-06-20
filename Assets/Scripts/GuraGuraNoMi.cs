using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;

public class GuraGuraNoMi : MonoBehaviour
{
    /*
    var hand = eventData.Controller as IMixedRealityHand;
    private int powerBar;
    private float rate;
    // Start is called before the first frame update
    void Start()
    {
        powerBar = 0;
        rate = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (powerBar == 1)
        {
            if (inReleasePosition && isFistClenched)
            {
                powerBar -= 5 * rate * time.deltaTime;
            }
            else if (!isFistClenched)
            {
                powerBar -= 5 * rate * time.deltaTime;
            }
            else
            {
                timer += time.deltaTime;
            }
        }
        else if (isFistClenched && inPosition)
        {
            powerBar += rate * time.deltaTime;
        }
        else if (isFistClenched && inReleasePosition)
        {
            powerBar -= 5 * rate * time.deltaTime;
        }
    }
    //Get whether or not first is clenched
    bool isFistClenched()
    {
        if (IsThumbGrabbing(hand) && IndexFingerCurl(hand) && MiddleFingerCurl(hand) && RingFingerCurl(hand) && PinkyFingerCurl(hand))
        {
            return true;
        }
        return false;
    }
    //Get if fist is in the proper charge spot and proper rotation
    bool inPosition()
    {
        return true;
    }
    bool inReleasePosition()
    {
        return true;
    }
    */
}
