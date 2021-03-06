using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day7Panel3 : MonoBehaviour
{
    float fadeAlpha;
    public GameObject nextPanel;
    public GameObject BGM;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Panel2());
    }

    IEnumerator Panel2()
    {
        //gameObject.SetActive(true);
        //등장하기
        fadeAlpha = 0.0f;   //처음 알파값
        BGM.GetComponent<AudioSource>().Play();

        while (fadeAlpha < 1.0f)
        {
            fadeAlpha += 0.01f;
            yield return new WaitForSeconds(0.01f); //0.01초 딜레이
            gameObject.GetComponent<Image>().color = new Color(gameObject.GetComponent<Image>().color.r, gameObject.GetComponent<Image>().color.g, gameObject.GetComponent<Image>().color.b, fadeAlpha);
        }

        yield return new WaitForSeconds(5.0f); //0.01초 딜레이

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
