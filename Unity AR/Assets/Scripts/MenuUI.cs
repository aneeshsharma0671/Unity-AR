using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum menuState
{
    main,
    chapter,
    concept
}

public class MenuUI : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject ChapterSelectPanel;
    public GameObject conceptSelectPanel;
    public float transitionSpeed = 1;

    uiManager UIManager;

    Vector3 uiActivePos = new Vector3(0, 0, 0);
    Vector3 uiDeactivepositive = new Vector3(2000, 0, 0);
    Vector3 uiDeactiveNegative = new Vector3(-2000, 0, 0);

    private void Start()
    {
        UIManager = FindObjectOfType<uiManager>();
        setMenuState(menuState.main);
    }

    public void setMenuState(menuState state)
    {
        switch (state)
        {
            case menuState.main:
                mainMenuPanel.GetComponent<RectTransform>().anchoredPosition = uiActivePos;
                ChapterSelectPanel.GetComponent<RectTransform>().anchoredPosition = uiDeactivepositive;
                conceptSelectPanel.GetComponent<RectTransform>().anchoredPosition = uiDeactivepositive;
                break;
            case menuState.chapter:
                mainMenuPanel.GetComponent<RectTransform>().anchoredPosition = uiDeactiveNegative;
                ChapterSelectPanel.GetComponent<RectTransform>().anchoredPosition = uiActivePos;
                conceptSelectPanel.GetComponent<RectTransform>().anchoredPosition = uiDeactivepositive;
                break;
            case menuState.concept:
                mainMenuPanel.GetComponent<RectTransform>().anchoredPosition = uiDeactiveNegative;
                ChapterSelectPanel.GetComponent<RectTransform>().anchoredPosition = uiDeactiveNegative;
                conceptSelectPanel.GetComponent<RectTransform>().anchoredPosition = uiActivePos;
                break;
            default:
                break;
        }
    }

    public void onClassSelect()
    {
        UIManager.leanTweenMenuPanel(mainMenuPanel, ChapterSelectPanel, -1, 1 / transitionSpeed);
    }

    public void onChapterBack()
    {
        UIManager.leanTweenMenuPanel(ChapterSelectPanel, mainMenuPanel, 1, 1 / transitionSpeed);
    }

    public void onChapterSelect()
    {
        UIManager.leanTweenMenuPanel(ChapterSelectPanel, conceptSelectPanel, -1, 1 / transitionSpeed);
    }
    public void onConceptBack()
    {
        UIManager.leanTweenMenuPanel(conceptSelectPanel, ChapterSelectPanel, 1, 1 / transitionSpeed);
    }

    public void onConceptSelect(int sceneIndex)
    {
        SceneInfo.ModelsIndex = sceneIndex;
        SceneManager.LoadScene(1);
    }
}
