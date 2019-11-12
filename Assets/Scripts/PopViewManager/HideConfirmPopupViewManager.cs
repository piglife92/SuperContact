using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideConfirmPopupViewManager : PopupViewManager
{
    public delegate void HideConfirmPopupViewManagerDelegate();
    public HideConfirmPopupViewManagerDelegate hideConfirmPopupViewManagerDelegate;

    public void OnClickHide()
    {
        hideConfirmPopupViewManagerDelegate?.Invoke();
        Close();
    }

    public void OnClickCancel()
    {
        Close();
    }
}
