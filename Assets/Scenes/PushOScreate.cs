using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Net;
using System.Text;

public class PushOScreate : MonoBehaviour
{
    /*
    var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

    request.KeepAlive = true;
    request.Method = "POST";
    request.ContentType = "application/json; charset=utf-8";

    request.Headers.Add("authorization", "Basic MzIyMWJiZjMtYjU0ZC00ZDBhLTk1MjktODNmNTY2MzlhYjVj");

    byte[] byteArray = Encoding.UTF8.GetBytes("{"
                                        + "\"app_id\": \"18acf8c9-f31d-485a-92ab-8d7b886be084\","
                                        + "\"contents\": {\"en\": \"English Message\"},"
                                        + "\"included_segments\": [\"All\"]}");

    string responseContent = null;

    try {
    using (var writer = request.GetRequestStream()) {
        writer.Write(byteArray, 0, byteArray.Length);
    }

    using (var response = request.GetResponse() as HttpWebResponse) {
        using (var reader = new StreamReader(response.GetResponseStream())) {
            responseContent = reader.ReadToEnd();
        }
    }
    }
    catch (WebException ex) {
    System.Diagnostics.Debug.WriteLine(ex.Message);
    System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
    }

    System.Diagnostics.Debug.WriteLine(responseContent);
    */
}

