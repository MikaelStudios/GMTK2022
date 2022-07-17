using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;
    public List<WaveSource> MusicChannels = new List<WaveSource>();
    public int startingIndex = 0;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayIndex(0, 0);
    }

    public void PlayIndex(int wave, int index)
    {
        for (int j = 0; j < MusicChannels.Count; j++)
        {
            for (int o = 0; o < MusicChannels[j].ads.Length; o++)
            {
                MusicChannels[j].ads[o].volume = 0;
            }
        }
        for (int i = 0; i < MusicChannels[wave].ads.Length; i++)
        {
            if (i == index)
            {
                MusicChannels[wave].ads[index].DOFade(1, .35f);
            }
            else if (MusicChannels[wave].ads[i].volume > 0)
            {
                MusicChannels[wave].ads[i].DOFade(0, .35f);
            }
            else
                MusicChannels[wave].ads[i].volume = 0;

        }
    }

    [System.Serializable]
    public class WaveSource
    {
        public AudioSource[] ads;
    }
}
