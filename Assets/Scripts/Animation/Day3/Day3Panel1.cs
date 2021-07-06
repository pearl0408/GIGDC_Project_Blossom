using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day3Panel1 : MonoBehaviour
{
    float fadeAlpha;
    public GameObject nextPanel;
    public GameObject movieTitle;
    string movie;

    // Start is called before the first frame update
    void Start()
    {
        string movie = GameManager.instance.selectMovie;
        if(movie=="romance")
        {
            movieTitle.GetComponent<Text>().text = "ROMANCE";
        }
        else if(movie=="action")
        {
            movieTitle.GetComponent<Text>().text = "ACTION";
        }
        else if (movie == "animation")
        {
            movieTitle.GetComponent<Text>().text = "ANIMATION";
        }
        else if (movie == "comedy")
        {
            movieTitle.GetComponent<Text>().text = "COMEDY";
        }
        else if (movie == "drama")
        {
            movieTitle.GetComponent<Text>().text = "DRAMA";
        }
        else if (movie == "horror")
        {
            movieTitle.GetComponent<Text>().text = "HORROR";
        }

        StartCoroutine(Panel1());
    }

    IEnumerator Panel1()
    {
        //gameObject.SetActive(true);
        //등장하기
        fadeAlpha = 0.0f;   //처음 알파값

        while (fadeAlpha < 1.0f)
        {
            fadeAlpha += 0.01f;
            yield return new WaitForSeconds(0.01f); //0.01초 딜레이
            gameObject.GetComponent<Image>().color = new Color(gameObject.GetComponent<Image>().color.r, gameObject.GetComponent<Image>().color.g, gameObject.GetComponent<Image>().color.b, fadeAlpha);
        }
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3.0f); //0.01초 딜레이

        fadeAlpha = 1.0f;   //처음 알파값

        //어두워지기
        while (fadeAlpha > 0.0f)
        {
            fadeAlpha -= 0.01f;
            yield return new WaitForSeconds(0.01f); //0.01초 딜레이
            gameObject.GetComponent<Image>().color = new Color(gameObject.GetComponent<Image>().color.r, gameObject.GetComponent<Image>().color.g, gameObject.GetComponent<Image>().color.b, fadeAlpha);
        }

        nextPanel.SetActive(true);

        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
