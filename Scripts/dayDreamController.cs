using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;

public class dayDreamController : MonoBehaviour {

	[SerializeField] private Camera mainCamera;
    [SerializeField] private Material shaderPath;

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
		

	}
	
	

	// Update is called once per frame

public void ReadString()
    {
        string path2 = "Assets/dayDream/Shaders/dayDreamShader.shader";
        StreamReader reader = new StreamReader(path2); 
        string content = new StreamReader(path2).ReadToEnd();
        string text4 = reader.ReadToEnd();
        text3 = mainInputField.text;
        mainInputField.text =content;
        reader.Close();
    }

public void WriteString()
    {

        string path = "Assets/dayDream/Shaders/dayDreamShader.shader";

        StreamWriter writer = new StreamWriter(path);
        text2 = mainInputField.text;
        writer.WriteLine(text2);
        writer.Close();

		mainInputField.text =text2;
        AssetDatabase.Refresh();

    }       

	void OnGUI(){



	}
	
    void Update(){

        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.Z))
        {
            // load script
        }
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.X))
        {
            string path = "Assets/dayDream/Shaders/dayDreamShader.shader";
            StreamWriter writer = new StreamWriter(path);
            text2 = mainInputField.text;
            writer.WriteLine(text2);
            writer.Close();

            mainInputField.text = text2;
            AssetDatabase.Refresh();
        }
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.R))
        {
            // reload shader to base
        }
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.C))
        {
            // change text color
        }
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.V))
        {
            // change background color
        }
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.B))
        {
            // toggle background
        }
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.D))
        {
            // toggle dayDream
        }



    }

}



