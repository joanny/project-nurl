/*
 * Crée par SharpDevelop.
 * Utilisateur: jsimpore
 * Date: 22/05/2014
 * Heure: 13:52
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Net;
namespace Project_10_Nurl
{
	class Program
	{
		public static void Main(string[] args)
		{
			//string cmd = "get -url https://www.google.fr/";
			string cmdSave = "get -url https://www.facebook.com/ -save C:/vm/";
			Controller controller = new Controller();
			
			bool val =	controller.doJob(cmdSave);
		
			
			
			Console.ReadKey(true);
		}
	}
}