/*
 * Crée par SharpDevelop.
 * Utilisateur: jsimpore
 * Date: 22/05/2014
 * Heure: 14:25
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;


namespace Project_10_Nurl
{
	/// <summary>
	/// Description of Nurl.
	/// </summary>
	public class Nurl
	{
		public  string url{get;set;}
		private string commande;
		public string option{get;set;}
		
		public Nurl( string uneUrl , string uneCommande )
		{
			this.url = uneUrl;
			this.commande =  uneCommande;
		}
		
		public Nurl( string uneUrl , string uneOption, string uneCommande )
		{
			this.url = uneUrl;
			this.commande =  uneCommande;
		}
	}
}
