using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideConfirmPopupViewManager : PopupViewManager
{
    public delegate void HideConfirmPopupViewManagerDelegate();
    public HideConfirmPopupViewManagerDelegate hideConfirmPopupViewManagerDelegate;

    public void OnClickOK()
    {
        hideConfirmPopupViewManagerDelegate?.Invoke();
        Close();
    }

    public void OnClickCancel()
    {
        Close();
    }
}
