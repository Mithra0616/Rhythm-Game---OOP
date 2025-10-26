using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hit : MonoBehaviour
{
    public int hitPoints=1;
    private SpriteRenderer sr;
    private Color OriginalColor;
    private Color FadedColor;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        OriginalColor = sr.color;
        FadedColor = new Color(sr.color.r, sr.color.g, sr.color.b, 0f);
        //StartCoroutine(AlphaLerp());
    }

    /*public IEnumerator AlphaLerp()
    {
        for (float i = 0; i < 1.5f; i += Time.deltaTime)
        {
            sr.color = Color.Lerp(OriginalColor, FadedColor, i / 1.5f);
            yield return null;
        }
    }*/

    public void OnMouseDown()
    {
        if (hitPoints == 1)
        {
            Debug.Log("Hit!");
            ScoreManager.instance.AddPoint();
           // StopCoroutine("AlphaLerp");
            Destroy(gameObject);
        }
        else if (hitPoints > 1)
        {
            hitPoints -= 1;
            Debug.Log("Hit!");

        }

    }
}
