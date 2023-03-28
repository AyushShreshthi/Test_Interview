using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSpawner : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Transform imagePos;
    [SerializeField] private RectTransform canvas;
    

    private void Start()
    {
        int width = Screen.width / 100;
        int height = Screen.height / 100;
        
        print(Screen.width + "  " + Screen.height);
        
        for(int i = 0; i < (width * height) ; i++)
        {
            GameObject obj = Instantiate(image.gameObject);
            obj.transform.SetParent(imagePos);
            obj.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);

            obj.GetComponent<Image>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        }
    }

    #region testing
    /*
     * 
     * Vector3 screenPos;
    bool onScreen;
    private void Update()
    {
        foreach (RectTransform child in transform)
        {
            Vector3[] childCorners = new Vector3[4];
            child.GetWorldCorners(childCorners);

            bool isOffscreen = true;

            foreach (Vector3 corner in childCorners)
            {
                print(corner);
                if (canvas.rect.Contains(corner))
                {
                    isOffscreen = false;
                    break;
                }
            }

            child.gameObject.SetActive(!isOffscreen);
        }
    }
    */

    #endregion
}
