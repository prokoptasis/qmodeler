using System;
using System.IO;
using System.Collections;

namespace ODS_Exporter
{
	/// <summary>
	/// Class1에 대한 요약 설명입니다.
	/// </summary>
	public class ODSExporter
	{
		public ODSExporter()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		private string FullPath;

		public void ODSExport(ArrayList table)
		{
			string FileName = (string)table[0] + ".dat";

			int Step = (int)table[1];
			int	headcnt = 2;
			int stepcnt = 1;

			string result = "";

			for(int i = headcnt; i < table.Count; i++)
			{
				result = result + table[i];
			
				if(stepcnt == Step)
				{
					stepcnt = 1;
					result = result + "\r\n";
				}
				else
				{
					stepcnt++;	
					result = result + ",";
				}
			}

			StreamWriter sw = new StreamWriter((FullPath + FileName), false, System.Text.Encoding.Default);
			sw.Write(result);
			sw.Close();
		}

		public bool SetFullPath()
		{
			BrowseForFolder bff = new BrowseForFolder();
			FullPath = bff.BrowseFolder("Select a folder to export Flat File");

			if(FullPath == "")
				return false;
			else
				return true;
		}
	}
}
