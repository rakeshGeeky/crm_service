namespace Terrasoft.Core.Process
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UsrProcess_10d5f75MethodsWrapper

	/// <exclude/>
	public class UsrProcess_10d5f75MethodsWrapper : ProcessModel
	{

		public UsrProcess_10d5f75MethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			string sender = "AutoAddVisits";  
			string msgbody = "something"; 
			MsgChannelUtilities.PostMessage(UserConnection, sender, msgbody);  
			return true; 
		}

		#endregion

	}

	#endregion

}

