using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform scrollView;
    private Transform viewPort;
    private Transform entryTemplate;
    private Transform scrollList;

    private void Awake()
    {
        entryContainer = transform.Find("RowScrollList");
        scrollView = entryContainer.Find("RowListViewport");
        viewPort = scrollView.Find("RowListContent");
        entryTemplate = viewPort.Find("highScoreEntryTamplate");

        entryTemplate.gameObject.SetActive(false);

        float templateHeight = 40f;
        for (int i = 0; i < 15; ++i)
        {
            Transform entryTransform = Instantiate(entryTemplate, viewPort);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            entryTransform.gameObject.SetActive(true);
        }
    }
}
