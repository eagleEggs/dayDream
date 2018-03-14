using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;

public class dayDreamController : MonoBehaviour {

	[SerializeField] private Camera mainCamera;
	[SerializeField] private string codeString = "hey";
	[SerializeField] private string codeString2 = "hey2";
	[SerializeField] private string stringToEdit = "hey";
	private GameObject windowCam;
	public TextAsset textFile;
	public InputField mainInputField;
	private Vector2 scrollPosition;
	public Button saveButton;
	public Button loadButton;
	public string text;
	public string text2;
	public string text3;


	// Use this for initialization

	void Start () {
		
	Button btn = saveButton.GetComponent<Button>();
    btn.onClick.AddListener(WriteString);

    Button btn2 = loadButton.GetComponent<Button>();
    btn2.onClick.AddListener(ReadString);

	windowCam = GameObject.Find( "SceneCamera" );
		
	//text = textFile.text;


	//mainInputField.text =text;






	}
	
	

	// Update is called once per frame

public void ReadString()
    {
        string path2 = "Assets/dayDream/Shaders/dayDreamShader.shader";
        //text = mainInputField.text;
        StreamReader reader = new StreamReader(path2); 
        string content = new StreamReader(path2).ReadToEnd();
        string text4 = reader.ReadToEnd();
        text3 = mainInputField.text;
        mainInputField.text =content;
        //Debug.Log(text3);
        reader.Close();
    }

public void WriteString()
    {
    	//text = textFile.text;
        string path = "Assets/dayDream/Shaders/dayDreamShader.shader";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path);
        text2 = mainInputField.text;
        writer.WriteLine(text2);
        writer.Close();

		mainInputField.text =text2;
		//Debug.Log(text2);
		AssetDatabase.Refresh();
}

	void OnGUI(){



	}
	

	void Update () {
		
    //Debug.Log("a");	



	}


}



