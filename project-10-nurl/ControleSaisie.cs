/*
 * Crée par SharpDevelop.
 * Utilisateur: jsimpore
 * Date: 22/05/2014
 * Heure: 14:32
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Text.RegularExpressions;
using System.IO;

namespace Project_10_Nurl
{
	/// <summary>
	/// Description of ControleSaisie.
	/// </summary>
	public  class ControleSaisie
	{
		private static bool IsUrlValid(string url)
		{
		    string pattern = @"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";
		    Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
		    return reg.IsMatch(url);
		}
		/**
		 *	Permet de valid la saisie pour le use case show
		 */
		public static bool validSaisieShow(string arguments){
			string[] tab =  arguments.Split(' ');			
			string get = "get";
			string url = "-url";
			
			bool valid = false;
			if ( tab[0].Equals(get)){
				if ( tab[1].Equals(url)){
					if ( IsUrlValid(tab[2])){
					    	valid = true;
					 }
				}
			}
			return valid;
		}
		
		/**
		 *	Permet de valid la saisie pour le use case show and save
		 */
		public static bool validSaisieSave(string arguments){
			string[] tab =  arguments.Split(' ');			
			string get = "get";
			string url = "-url";
			string save = "-save";
			
			bool valid = false;
			if ( tab[0].Equals(get)){
				if ( tab[1].Equals(url)){
					if ( IsUrlValid(tab[2])){
						if (tab[3].Equals(save)){
							if (RepExist(tab[4])){
								valid  = true;
							}else{
							Console.Write("rep faux");
						}
						}else{
							Console.Write("save faux");
						}
					    	
					 }else{
					Console.Write("adr faux");
				}
				}else{
					Console.Write("url faux");
				}
			}
			return valid;
		}
		public static bool RepExist(string path){
			return Directory.Exists(path);
		}
		public static string[] getArgs(string arguments){
			return arguments.Split(' ');
		}
	}
}
