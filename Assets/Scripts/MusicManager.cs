using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public GameObject AudioManager;
    public void stopMusic()
    {
        foreach (Transform child in AudioManager.transform)
            child.gameObject.SetActive(false);
    }
    public void startMusic(int track)
    {
        stopMusic();
        print(AudioManager.transform.GetChild(track).gameObject.name);
        print(track);
        AudioManager.transform.GetChild(track).gameObject.SetActive(true);
    }
    public void initialize()
    {
        stopMusic();
    }

}
