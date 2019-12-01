using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ball : MonoBehaviour
{

    public Text score;
    public Text life;
    private int scoreNum = 0;
    private int lifetime = 3;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        score.text = "Score : " + scoreNum;
        life.text = "Life : " + lifetime;

    }


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Pillar")
        {
            scoreNum += 10;
        }

        if (col.gameObject.tag == "die")
        {

            this.transform.position = new Vector3(-35, 17, 16);

            lifetime--;
        }


        if (lifetime == 0) {
            //end game 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
