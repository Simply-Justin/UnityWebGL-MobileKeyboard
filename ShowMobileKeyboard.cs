using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ShowMobileKeyboard : MonoBehaviour, ISelectHandler {

	[DllImport("__Internal")]
	private static extern void OpenTextPromt (string _name, string _str, string _promtText);

	public string promptTitle;

	public void ReceiveInputData(string value) {
		gameObject.GetComponent<InputField> ().text = value;
	}

	public void OnSelect(BaseEventData data) {
		#if UNITY_WEBGL
		try{
			OpenTextPromt (gameObject.name, gameObject.GetComponent<InputField> ().text, promptTitle);
		}
		catch(Exception error){}
		#endif
	}
}
