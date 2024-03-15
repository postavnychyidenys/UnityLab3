using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour
{
    [SerializeField] AudioClip jump;
    [SerializeField] AudioClip die;

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(jump, transform.position);
    }

    private void OnDestroy()
    {
        AudioSource.PlayClipAtPoint(die, transform.position);
    }
}
