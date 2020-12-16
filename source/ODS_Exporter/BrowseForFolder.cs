using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ODS_Exporter
{
	/// <summary>
	/// BrowseForFolder에 대한 요약 설명입니다.
	/// </summary>
	public class BrowseForFolder : FolderNameEditor
	{
		FolderNameEditor.FolderBrowser myFolderBrowser;

		public string BrowseFolder(string title)
		{
			string myPath = "";
			
			myFolderBrowser = new FolderNameEditor.FolderBrowser();
			
			// Description
			myFolderBrowser.Description = title;
			// ShowDialog			
			DialogResult r = myFolderBrowser.ShowDialog();
			// Shall I add the "\" character at the end of the path ?

			if(r == DialogResult.OK)
			{
				// DirectoryPath
				myPath = myFolderBrowser.DirectoryPath;

				if (myPath.Length > 0 ) 
				{


					if (myPath.Substring((myPath.Length - 1),1) != "\\") 
						myPath += "\\";
				}
			}
			// Return correct path

			return myPath;
		}
		
		~BrowseForFolder()
		{
			myFolderBrowser.Dispose(); // Dispose
		}
	}
}
