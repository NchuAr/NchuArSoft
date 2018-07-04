using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ARUIManager : MonoBehaviour {

    private Camera arCamera;
    public Text text;


    void Start()
    {
    
        arCamera = GameObject.Find("ARCamera").GetComponent<Camera>();
    }



    //截图
    public void ScreenShot()
    {
        System.DateTime now = System.DateTime.Now;
        string times = now.ToString();
        times = times.Trim();
        times = times.Replace("/", "-");

        string fileName = "ARScreenShot" + times + ".png";

        if (Application.platform == RuntimePlatform.Android)
        {
            RenderTexture rt = new RenderTexture(Screen.width,Screen.height,1);
            arCamera.targetTexture = rt;
            arCamera.Render();

            RenderTexture.active = rt;

            Texture2D texture = new Texture2D(Screen.width, Screen.height,TextureFormat.RGB24,false);
            texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
            texture.Apply();

            arCamera.targetTexture = null;
            RenderTexture.active = null;
            Destroy(rt);

            byte[] bytes = texture.EncodeToPNG();

            string destination = "/sdcard/DCIM/Screenshots";

            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }

            string pathSave = destination + "/" + fileName;

            File.WriteAllBytes(pathSave, bytes);

        }
        text.enabled = true;
        StartCoroutine("TextChange");
    }


    IEnumerator TextChange()
    {
        yield return new WaitForSeconds(2);
        text.enabled = false;
    }

    public void Return()
    {
       
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
}
