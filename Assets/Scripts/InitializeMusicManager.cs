using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MusicManager;

public class InitializeMusicManager : MonoBehaviour
{
    MusicManager manage = null;
    public GameObject AudioManager;
    // Start is called before the first frame update
    void Start()
    {
        manage = gameObject.AddComponent<MusicManager>();
        manage.AudioManager = this.AudioManager;
        manage.initialize();
    }

}
