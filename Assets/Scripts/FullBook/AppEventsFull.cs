
using System;

public static class AppEventsFull
{
    public static event EventHandler CloseBookFull;
    public static event EventHandler OpenBookFull;

    public static void CloseBookFunctionFull()
    {
        if (CloseBookFull != null)
            CloseBookFull(new object(), new EventArgs());
    }

    public static void OpenBookFunctionFull()
    {
        if (OpenBookFull != null)
            OpenBookFull(new object(), new EventArgs());
    }
}
