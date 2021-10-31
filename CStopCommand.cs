using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Bujor_Denisa_Lab2.CustomCommands
{
   class CStopCommand
{
    private static RoutedUICommand launch_command;
    static CStopCommand()
    {
        InputGestureCollection myInputGestures = new InputGestureCollection();
        myInputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
        launch_command = new RoutedUICommand("Launch", "Launch",
       typeof(CStopCommand), myInputGestures);
    }
    public static RoutedUICommand Launch
    {
        get
        {
            return launch_command;
        }
    }
}
}

