using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource sfxSource;
    public AudioClip wingClip;
    public AudioClip pointClip;
    public AudioClip hitClip;
    public AudioClip dieClip;

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

        if (sfxSource == null)
            sfxSource = GetComponent<AudioSource>();
    }

    public void PlayWing()
    {
        if (sfxSource != null && wingClip != null)
            sfxSource.PlayOneShot(wingClip);
    }

    public void PlayPoint()
    {
        if (sfxSource != null && pointClip != null)
            sfxSource.PlayOneShot(pointClip);
    }

    public void PlayHit()
    {
        if (sfxSource != null && hitClip != null)
            sfxSource.PlayOneShot(hitClip);
    }

    public void PlayDie()
    {
        if (sfxSource != null && dieClip != null)
            sfxSource.PlayOneShot(dieClip);
    }
}