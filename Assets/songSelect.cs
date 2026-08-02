using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class songSelect: MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] songs;

    void Start()
    {
        dropdown.ClearOptions();

        List<string> songNames = new List<string>();

        foreach (AudioClip song in songs)
        {
            songNames.Add(song.name);
        }

        dropdown.AddOptions(songNames);

        dropdown.onValueChanged.AddListener(ChangeSong);

        ChangeSong(0);
    }

    void ChangeSong(int index)
    {
        audioSource.clip = songs[index];
        audioSource.Play();
    }
}
