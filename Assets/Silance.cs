using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //AkSoundEngine.SetVolumeThreshold(10);
        //AkSoundEngine.SetOutputVolume(0, 1);
    }

    private void OnTriggerExit(Collider other)
    {
        //AkSoundEngine.SetVolumeThreshold(20);
        //AkSoundEngine.SetOutputVolume(0, 10);
    }
}
