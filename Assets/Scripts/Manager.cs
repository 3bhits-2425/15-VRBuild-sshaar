using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject player;

    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio4;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Plane1")
        {
            PlayClip(audio1);
        }
        else if (other.gameObject.name == "Plane2")
        {
            PlayClip(audio2);
        }
        else if (other.gameObject.name == "Plane3")
        {
            PlayClip(audio3);
        }
        else if (other.gameObject.name == "Plane4")
        {
            PlayClip(audio4);
        }
    }

    void PlayClip(AudioClip clip)
    {
        if (clip != null)
        {
            audioSource.Stop();
            audioSource.clip = clip;
            audioSource.Play();
        }
    }
}

