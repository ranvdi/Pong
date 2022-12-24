using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{
    public Audio[] audios;
    public static bool isSoundOpen;
    public GameObject Slider;

    private void Start()
    {
        isSoundOpen = true;

    }


    public void playsong(string name)
    {
        foreach (Audio item in audios)
        {
            if(item.name == name)
            {
                if (item.source == null)
                    item.source = gameObject.AddComponent<AudioSource>();

                item.source.clip = item.clip;
                item.source.volume = item.volume;
                item.source.loop = item.loop;

                item.source.Play();
                break;
            }
        }
    }

    public void closesong()
    {
        if (Slider=0)
        {
            foreach(var item in audios)
            {
                if (item.source != null)
                    item.source.volume = 0;
            }
            isSoundOpen = false;
        }
        else
        {
            foreach (var item in audios)
            {
                if (item.source != null)
                    item.source.volume = 1;
            }
            isSoundOpen = true;
        }
    }
}
