using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    public event UnityAction NextScene;

    public void LoadScene()
    {
        _audio.Play();
        StartCoroutine(DelayNextScene());
    }

    IEnumerator DelayNextScene()
    {
        yield return new WaitForSeconds(.4f);

        NextScene?.Invoke();
    }
}
