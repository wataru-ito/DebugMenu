using UnityEngine;
using DebugMenuSystem;

public class Sample : MonoBehaviour
{
	DebugMenuWindow m_debugMenuWindow;

	public bool flag;

	void Start()
	{
		new DebugMenu("Sample/ApplicationInfo", DrawApplicationInfo);

		new DebugMenuToggle("Sample/Toggle/flag",
			() => flag,
			f => flag = f,
			"今はFALSE", "今はTRUE");

		new DebugMenuButton("Sample/Button/DateTimeNow", PrintDateTimeNow);
	}

	void DrawApplicationInfo()
	{
		GUILayout.Label("FPS : " + Application.targetFrameRate);
		GUILayout.Label("DataPath : " + Application.dataPath);
	}
	
	public void PrintDateTimeNow()
	{
		Debug.Log(System.DateTime.Now.ToString());
	}

	public void OpenDebugMenu()
	{
		if (!m_debugMenuWindow)
		{
			m_debugMenuWindow = DebugMenuWindow.Create();
		}
	}
}
