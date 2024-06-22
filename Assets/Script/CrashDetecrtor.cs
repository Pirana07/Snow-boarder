using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetecrtor : MonoBehaviour
{
    [SerializeField]float Wait = 0.3f;
 [SerializeField]ParticleSystem finisheffect;
 bool hascrashed = false;

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Ground" && !hascrashed){
        hascrashed = true;
        Debug.Log("Ouch!");
        Invoke("SceneReload", Wait);
        finisheffect.Play();
        GetComponent<AudioSource>().Play();
        FindObjectOfType<Controller>().Disable();
        }
    }

    void SceneReload(){
        SceneManager.LoadScene(0);
    }
    
}