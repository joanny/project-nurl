/*
 * Crée par SharpDevelop.
 * Utilisateur: joanny
 * Date: 24/05/2014
 * Heure: 13:07
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Net.NetworkInformation;

namespace Project_10_Nurl
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Controller
	{
		public Controller()
		{
			
		}
		
		public bool doJob(string arguments){
			bool exec = false;
			//bool valid = ControleSaisie.validSaisieShow(arguments);
			bool validSave = ControleSaisie.validSaisieSave(arguments);
			
			string[] args = ControleSaisie.getArgs(arguments);
		
			if (validSave){
				exec = true;
				switch (args.Length){
						case 3:  {
							Console.Write(" 3 arg");
							Nurl uneCmd = new Nurl(args[2], args[1]);
							string content = ActionUrl.getWebContent(uneCmd);
							break;
						}
						case 5: {
							Console.Write(" 5 arg");
							Nurl uneCmd = new Nurl(args[2], args[1], args[4]);
							ActionUrl.getWebContentAndSave(uneCmd);
							break;
						}
						default : {
							Console.Write(" wrong req");
							exec = false;
							break;
						}
				}
			}
			return exec;
		}
		
		
		
	public static bool PingHost(string nameOrAddress)
    {
        bool pingable = false;
        Ping pinger = new Ping();

        try
        {
            PingReply reply = pinger.Send(nameOrAddress);

            pingable = reply.Status == IPStatus.Success;
        }
        catch (PingException)
        {
            // Discard PingExceptions and return false;
        }

        return pingable;
    
	}
	}
}
