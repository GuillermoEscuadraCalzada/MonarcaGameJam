using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;

public class VideoEvents : MonoBehaviour
{
    [SerializeField] VideoPlayer player;
    [SerializeField] UnityEvent videoFinished;

    // Start is called before the first frame update
    void Start()
    {
        player.loopPointReached += VideoFinish;
    }

    private void VideoFinish(VideoPlayer vp)
    {
        videoFinished.Invoke();
    }
}
