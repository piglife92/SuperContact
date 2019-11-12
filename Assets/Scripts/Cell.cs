﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface ICell
{
    void DidSelectCell(Cell cell);
    void DidSelectDeleteCell(Cell cell);

    void DidSelectHideCell(Cell cell);
}

public class Cell : MonoBehaviour
{
    [SerializeField] Text title;
    [SerializeField] Button deleteButton;
    [SerializeField] Image profilePhoto;
    [SerializeField] Button hideButton;

    public ICell cellDelegate;
    Button cellButton;

    public string Title
    {
        get
        {
            return this.title.text;
        }
        set
        {
            // title에 대한 유효성 체크
            this.title.text = value;
        }
    }

    public Sprite ProfilePhotoSprite
    {
        get
        {
            return this.profilePhoto.sprite;
        }
        set
        {
            this.profilePhoto.sprite = value;
        }
    }

    public bool ActiveDelete
    {
        get 
        {
            return deleteButton.gameObject.activeSelf;
        }
        set
        {
            deleteButton.gameObject.SetActive(value);
            hideButton.gameObject.SetActive(value);

            if (value)
            {
                cellButton.interactable = false;
            }
            else
            {
                cellButton.interactable = true;
            }
                // cellButton.interactable = !value;
        }
    }

    private void Start() 
    {
        cellButton = GetComponent<Button>();
        this.ActiveDelete = false;
    }

    public void OnClick()
    {
        cellDelegate.DidSelectCell(this);
    }

    public void OnClickDelete()
    {
        cellDelegate.DidSelectDeleteCell(this);
    }

    public void OnClickHide()
    {
        cellDelegate.DidSelectHideCell(this);
    }
}
