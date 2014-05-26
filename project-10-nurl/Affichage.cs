/*
 * Crée par SharpDevelop.
 * Utilisateur: joanny
 * Date: 26/05/2014
 * Heure: 21:28
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;

namespace Project_10_Nurl
{
	/// <summary>
	/// Description of Affichage.
	/// </summary>
	public class Affichage
	{
		public  static void show(string content){
			Console.Write("*******Voici le contenu de la page chargée*******");
			Console.WriteLine(content);
		}
		
	}
}
