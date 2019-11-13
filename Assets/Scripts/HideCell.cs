using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IHideCell
{
    void DidSelectHideCell(HideCell hidecell);
    void DidSelectRevealCell(HideCell hidecell);
}

public class HideCell : MonoBehaviour
{
    [SerializeField] Button revealButton;

    public IHideCell hidecellDelegate;
    Button hidecellButton;

    public bool ActiveReveal
    {
        get
        {
            return revealButton.gameObject.activeSelf;
        }
        set
        {
            revealButton.gameObject.SetActive(value);

            if (value)
            {
                hidecellButton.interactable = false;
            }
            else
            {
                hidecellButton.interactable = true;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hidecellButton = GetComponent<Button>();
        this.ActiveReveal = false;
    }

    public void OnClick()
    {
        hidecellDelegate.DidSelectHideCell(this);
    }

    public void OnClickReveal()
    {
        hidecellDelegate.DidSelectRevealCell(this);
    }
}
