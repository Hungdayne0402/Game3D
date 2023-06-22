using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour
{
    [SerializeField] private AudioClip audio;
    [SerializeField] private string sceneName;

    public void LoadingScene()
    {
        SoundManager.Instance.PlaySound(audio);//bat am thanh
        Application.LoadLevel(sceneName);//goi scene khac
        // ScoreManager.score = 0f;//reset diem
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
