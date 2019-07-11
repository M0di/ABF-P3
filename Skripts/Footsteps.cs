using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {

    private string GroundMat;
    private bool Landet = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayFootsteps()
    {
        if(GroundMat == "Dirt"){
            AkSoundEngine.PostEvent("FootstepGravel", gameObject);
        }
        if (GroundMat == "Gras")
        {
            AkSoundEngine.PostEvent("FootstepWood", gameObject);
        }
        if (GroundMat == "Stone")
        {
            AkSoundEngine.PostEvent("FootstepStone", gameObject);
        }
    }

    public void PlayFootstepsCrouch()
    {
        if (GroundMat == "Dirt")
        {
            AkSoundEngine.PostEvent("FootstepGravel", gameObject);
        }
        if (GroundMat == "Gras")
        {
            AkSoundEngine.PostEvent("FootstepWood", gameObject);
        }
        if (GroundMat == "Stone")
        {
            AkSoundEngine.PostEvent("FootstepStone", gameObject);
        }
    }

    public void Jump()
    {
        if (Landet)
        {
            Landet = false;
            AkSoundEngine.PostEvent("Jump", gameObject);

        }
    }

    public void Land()
    {
            Landet = true;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Dirt")
        {
            GroundMat = "Dirt";
        }

        if (collision.gameObject.tag == "Gras")
        {
            GroundMat = "Gras";
        }

        if (collision.gameObject.tag == "Stone")
        {
            GroundMat = "Stone";
        }
    }

}
