/*
 * Crée par SharpDevelop.
 * Utilisateur: joanny
 * Date: 24/05/2014
 * Heure: 01:27
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Net;
namespace Project_10_Nurl
{
	
	/// <summary>
	/// Description of Action.
	/// </summary>
	public class ActionUrl
	{
			public static string REP_NAME = "C:/fileDownload/" ;
			
			public static string getRepName(){
				return REP_NAME;
			}
			public static string getWebContent(Nurl uneCmd){
				Console.Write(uneCmd.url);
				WebClient client = new WebClient ();
				return client.DownloadString(uneCmd.url);
			}
		
			public static void getWebContentAndSave(Nurl uneCmd){
				Console.Write(uneCmd.url);
				WebClient client = new WebClient();
				
				client.DownloadFile(uneCmd.url, getRepName()+uneCmd.option );
			}
	}
}
