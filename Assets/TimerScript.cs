using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private UnityEvent timerEnd;
    [SerializeField] private UnityEvent timer2End;
    [SerializeField] private float timerDuration = 1.0f;
    [SerializeField] private AudioSource myAudioSource;
    
    
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        StartCoroutine("SetTimer1");
    }

    IEnumerator SetTimer1()
    {
        
        yield return new WaitForSeconds(timerDuration);
        //timerEnd.Invoke();
        myAudioSource.enabled = true;
        StartCoroutine("SetTimer2");
    }
    
    IEnumerator SetTimer2()
    {
        
        yield return new WaitForSeconds(timerDuration);
        timer2End.Invoke();
        StartCoroutine("SetTimer1");
    }
}
