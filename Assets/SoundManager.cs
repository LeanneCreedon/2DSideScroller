using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip EagleAttack, GameOver, CherryPickup, JumpSound, LevelComplete, GemCollectSound, frogAttack;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    public void Start()
    {
        EagleAttack = Resources.Load<AudioClip> ("eagleAttack");
        GameOver = Resources.Load<AudioClip> ("gameOver");
        CherryPickup = Resources.Load<AudioClip> ("cherryPickup");
        JumpSound = Resources.Load<AudioClip> ("jumpSound");
        LevelComplete = Resources.Load<AudioClip> ("levelComplete");
        GemCollectSound = Resources.Load<AudioClip> ("gemCollectSound");
        frogAttack = Resources.Load<AudioClip> ("frogAttack");

        audioSrc = GetComponent<AudioSource> ();   
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "eagleAttack":
                audioSrc.PlayOneShot (EagleAttack);
                break;

            case "gameOver":
                audioSrc.PlayOneShot (GameOver);
                break;

            case "cherryPickup":
                audioSrc.PlayOneShot (CherryPickup);
                break;

            case "jumpSound":
                audioSrc.PlayOneShot (JumpSound);
                break;

            case "levelComplete":
                audioSrc.PlayOneShot (LevelComplete);
                break;

            case "gemCollectSound":
                audioSrc.PlayOneShot (GemCollectSound);
                break;

            case "frogAttack":
                audioSrc.PlayOneShot (frogAttack);
                break;
        }
    }
}
