using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    #region SINGLETON
    public static AudioManager instance;
    private void Awake() {
        if(instance)
            Destroy(this);
        else
            instance = this;
    }
    # endregion
    
    public AudioListener listener;
    [SerializeField] AudioSource source;
    

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void Pause()
    {
        source.Pause();
    }

    public void Play()
    {
        source.Play();
    }

    public void Stop()
    {
        source.Stop();
    }

    public void PlayClip(AudioClip clip)
    {
        source.clip = clip;
        Play();
    }

    public void PlayRandomOneShot(AudioClip[] clips)
    {
        if(clips == null || clips.Length == 0)
            return;
        int index = Random.Range(0,clips.Length+1);
        source.PlayOneShot(clips[index]);
    }

    public void PlayOneShot(AudioClip clip)
    {
        if(clip == null)
            return;
        source.PlayOneShot(clip);
    }

}
