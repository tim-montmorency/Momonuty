using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayerClipCarousel: MonoBehaviour
{
    UnityEngine.Video.VideoPlayer videoPlayer;
    public UnityEngine.Video.VideoClip[]  videoClips;
    int videoIndex = 0;
    void Start()
    {
        videoPlayer = gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();
    }
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space))
        {
            videoIndex = (videoIndex + 1) % videoClips.Length;
            videoPlayer.clip = videoClips[videoIndex];
        }
    }
}

