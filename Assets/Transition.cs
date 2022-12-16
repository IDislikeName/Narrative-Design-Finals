using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Transition : MonoBehaviour
{
    public bool changing;
    public Image im;
    // Start is called before the first frame update
    void Start()
    {
        im = GetComponent<Image>();
        StartCoroutine(trans());
    }

    // Update is called once per frame
    void Update()
    {
        if (changing)
        {
            im.color = new Color(0,0,0,im.color.a-Time.deltaTime/4);
        }
    }
    public IEnumerator trans()
    {
        changing = true;
        yield return new WaitForSeconds(4f);
        gameObject.SetActive(false);
    }
}
