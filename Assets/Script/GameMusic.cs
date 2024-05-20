using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    AudioSource gameAudio;
    
    // Start is called before the first frame update
    void Start()
    {
        gameAudio = GetComponent<AudioSource>();
        loadMusicTime();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadMusicTime()
    {
        float time = PlayerPrefs.GetFloat("musicPosition");
        StartCoroutine(Delay());
        gameAudio.time= time;
    }

    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
    }
}
