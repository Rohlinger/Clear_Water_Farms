﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ToolTip : MonoBehaviour
{
  /*  private static ToolTip instance;
    private Text tooltipText;
    private RectTransform backgroundRectTransform;
    [SerializeField] private Camera uiCamera;
    [SerializeField] private RectTransform canvasRectTransform;
    private Func<string> getTooltipStringFunc;

    private void Awake()
    {
        instance = this;
        backgroundRectTransform = transform.Find("background").GetComponent<RectTransform>();
        tooltipText = transform.Find("text").GetComponent<Text>();
        HideTooltip();


      ShowTooltip("random");
    }

    private void Update()
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(), Input.mousePosition, uiCamera, out localPoint);
        transform.localPosition = localPoint;
        SetText(getTooltipStringFunc());
        Vector2 anchoredPosition = transform.GetComponent<RectTransform>().anchoredPosition;
        if(anchoredPosition.x + backgroundRectTransform.rect.width> canvasRectTransform.rect.width)
        {
            anchoredPosition.x = canvasRectTransform.rect.width - backgroundRectTransform.rect.width;
        }
        if(anchoredPosition.y + backgroundRectTransform.rect.height > canvasRectTransform.rect.height)
        {
            anchoredPosition.y = canvasRectTransform.rect.height - backgroundRectTransform.rect.height;
        }
        transform.GetComponent<RectTransform>().anchoredPosition = anchoredPosition;
    }

private void ShowTooltip(string tooltipString)
    {
        ShowTooltip(() => tooltipString); 
    }

    private void ShowTooltip (Func<string> getTooltipStringFunc) 
    { 
        gameObject.SetActive(true);
        transform.SetAsLastSibling();
        this.getTooltipStringFunc = getTooltipStringFunc;
        SetText(getTooltipStringFunc());
    }


   

    private void SetText(string tooltipString)
    {
        tooltipText.text = tooltipString;
        float textPaddingSize = 4f;
        Vector2 backgroundSize = new Vector2(tooltipText.preferredWidth + textPaddingSize * 2f, tooltipText.preferredHeight + textPaddingSize * 2f);
        backgroundRectTransform.sizeDelta = backgroundSize;
        Update();
    }

    private void HideTooltip()
    {
        gameObject.SetActive(false);
    }

    public static void AddTooltip(Transform transform, string tooltipString)
    {
        AddTooltip(transform, () => tooltipString);
    }

    public static void AddTooltip(Transform transform, Func<string> getTooltipStringFunc)
    {
        if(transform.GetComponent<Button_UI>() != null)
        {
            transform.GetComponent<Button_UI>().MouseOverOnceTooltipFunc = () => ToolTip.ShowTooltip_Static(getTooltipStringFunc);
            transform.GetComponent<Button_UI>().MouseOutOnceTooltipFunc = () => ToolTip.HideTooltip_Static();
        }
    }

    public static void ShowTooltip_Static(string tooltipString)
    {
        instance.ShowTooltip(tooltipString);
       
    }

    public static void ShowTooltip_Static(Func<string> getTooltipStringFunc)
    {
        instance.ShowTooltip(getTooltipStringFunc);
    }

    public static void HideTooltip_Static()
    {
        instance.HideTooltip();
    }

   
}
public static class Tooltip_Extensions
{
    public static void AddTooltip(this Transform transform, string tooltipString)
    {
        transform.AddTooltip(() => tooltipString);
    }
    public static void AddTooltip(this Transform transform, Func<string> getTooltipStringFunc)
    {
        ToolTip.AddTooltip(transform, getTooltipStringFunc);
    }*/
}