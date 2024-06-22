using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField]float Wait = 1f;
    [SerializeField]ParticleSystem finisheffect;
    void OnTriggerEnter2D(Collider2D other){
       
    if(other.tag == "Player"){
        
        Invoke("ReloadScene", Wait);
       finisheffect.Play();
       GetComponent<AudioSource>().Play();
        }
  }
  void ReloadScene(){
    SceneManager.LoadScene(0);
    
  }
}
