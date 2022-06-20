using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
   public GameObject MusicMenu;
   public GameObject DevilFruitsMenu;
   public void initialize()
   {
        MusicMenu.SetActive(false);
        DevilFruitsMenu.SetActive(false);
    }
   public void toggleMusicMenu()
    {
        MusicMenu.SetActive(!MusicMenu.activeSelf);
        DevilFruitsMenu.SetActive(false);
    }
    public void toggleDevilFruitsMenu()
    {
        DevilFruitsMenu.SetActive(!DevilFruitsMenu.activeSelf);
        MusicMenu.SetActive(false);
    }
}
