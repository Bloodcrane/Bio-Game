using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMaterialType : MonoBehaviour
{
    public FootstepSounds fst;
    public string m_grass;
    public string m_ground;
    public string m_marble;
    public string m_wood;
    public string m_water;
    public string m_metal;

    public AudioClip marble;
    public AudioClip marble_run;

    public float maxDistance;
    [SerializeField]
    private string hitMat;

    public void raycastDetect()
    {
        RaycastHit hit;

        bool isHit = Physics.Raycast(transform.position, transform.forward, out hit, maxDistance);

        if (isHit)
        {
            hitMat = hit.transform.tag;
            hitMat = hit.collider.tag;
        }

        if (hitMat == m_marble)
        {
            fst.Walk1 = marble;
            fst.WalkAudio.clip = marble;
            fst.RunAudio.clip = marble_run;
            fst.Run1 = marble_run;
        }
    }
    private void Update() 
    {
        raycastDetect();
    }



}
