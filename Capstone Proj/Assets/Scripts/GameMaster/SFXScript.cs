using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXScript : MonoBehaviour
{
    public static AudioClip jump, collect, power, die, bouncesfx;
    public static AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        jump = Resources.Load<AudioClip>("jumpsfx");
        collect = Resources.Load<AudioClip>("gemcollect");
        power = Resources.Load<AudioClip>("powerup");
        die = Resources.Load<AudioClip>("death");
        bouncesfx = Resources.Load<AudioClip>("boing");

        source = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlayAudio(string clip)
    {
        switch (clip)
        {
            case "jumpsfx":
                source.PlayOneShot(jump);
                break;
            case "gemcollect":
                source.PlayOneShot(collect);
                break;
            case "powerup":
                source.PlayOneShot(power);
                break;
            case "death":
                source.PlayOneShot(die);
                break;
            case "boing":
                source.PlayOneShot(bouncesfx);
                break;
        }
    }
}
