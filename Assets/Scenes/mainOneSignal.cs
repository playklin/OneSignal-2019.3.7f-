using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainOneSignal : MonoBehaviour
{
    void Start () {
    // Enable line below to enable logging if you are having issues setting up OneSignal. (logLevel, visualLogLevel)
    // OneSignal.SetLogLevel(OneSignal.LOG_LEVEL.INFO, OneSignal.LOG_LEVEL.INFO);
  
    OneSignal.StartInit("18acf8c9-f31d-485a-92ab-8d7b886be084")
    .HandleNotificationOpened(HandleNotificationOpened)
    .EndInit();
  
     OneSignal.inFocusDisplayType = OneSignal.OSInFocusDisplayOption.Notification;
    }

    // Gets called when the player opens the notification.
    private static void HandleNotificationOpened(OSNotificationOpenedResult result) {
    }
}
