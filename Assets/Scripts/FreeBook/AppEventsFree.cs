
using System;

public static class AppEventsFree
{
    public static event EventHandler CloseBookFree;
    public static event EventHandler OpenBookFree;

    public static void CloseBookFunctionFree()
    {
        if (CloseBookFree != null)
            CloseBookFree(new object(), new EventArgs());
    }

    public static void OpenBookFunctionFree()
    {
        if (OpenBookFree != null)
            OpenBookFree(new object(), new EventArgs());
    }
}
