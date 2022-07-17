using DG.Tweening;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;
    public AudioSource[] MusicChannels;
    public int startingIndex = 0;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayIndex(0);
    }

    public void PlayIndex(int index)
    {
        for (int i = 0; i < MusicChannels.Length; i++)
        {
            if (i == index)
            {
                MusicChannels[index].DOFade(1, .35f);
            }
            else if (MusicChannels[i].volume > 0)
            {
                MusicChannels[i].DOFade(0, .35f);
            }
            else
                MusicChannels[i].volume = 0;

        }
    }
}
