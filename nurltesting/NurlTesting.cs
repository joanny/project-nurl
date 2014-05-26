/*
 * Crée par SharpDevelop.
 * Utilisateur: jsimpore
 * Date: 22/05/2014
 * Heure: 15:34
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using NUnit;
using NUnit.Framework;
using  Project_10_Nurl;

namespace NurlTesting
{
	[TestFixture]
	class NurlTesting
	{
		[Test]
		public void testControleSaisie_vrai()
		{
			//String cmd = "get -url sdsdsdsd";
			//string[] CtrlSaisie = ControleSaisie.getSaisie(cmd);
			//Assert.AreEqual(3, CtrlSaisie.Length);
		}
		[Test]
		public void testControleSaisie_faux()
		{
			//String cmd = "get -u https://www.google.fr/  dsfqdsfc";
			//string[] CtrlSaisie = ControleSaisie.getSaisie(cmd);
			//Assert.AreNotEqual(3, CtrlSaisie.Length);
		}
		
		public static void Main(string[] args)
		{
			Console.ReadKey(true);
		}
		 
	}
}