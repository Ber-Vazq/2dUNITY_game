using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int Score;
    public TMP_Text ScoreText;
    public AudioClip audioClip;
 
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "Point")
        {
            Destroy(other.gameObject);
            AddScore();
            GetComponent<AudioSource>().PlayOneShot(audioClip);
        }
        else if(other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("EndGame");
        }
    }
    void AddScore(){
        Score++;
        ScoreText.text = Score.ToString();
    }
}
