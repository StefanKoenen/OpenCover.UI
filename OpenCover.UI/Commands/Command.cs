﻿//
// This source code is released under the MIT License; Please read license.md file for more details.
//
using Microsoft.VisualStudio.Shell;
using System;
using System.ComponentModel.Design;

namespace OpenCover.UI.Commands
{
	/// <summary>
	/// Base command for menu commands
	/// </summary>
	public abstract class Command : OleMenuCommand
	{
	    protected OpenCoverUIPackage Package { get; private set; }
	    private CommandID _commandID;

		/// <summary>
		/// Initializes a new instance of the <see cref="Command" /> class.
		/// </summary>
		/// <param name="package">The Visual Studio extension package.</param>
		/// <param name="commandID">The command identifier.</param>
		protected Command(OpenCoverUIPackage package, CommandID commandID)
			: base(CommandExecuted, commandID)
		{
			this.Package = package;
			this._commandID = commandID;
		}

		/// <summary>
		/// Execute the specified sender.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private static void CommandExecuted(object sender, EventArgs e)
		{
			var command = sender as Command;
			command.OnExecute();
		}

		/// <summary>
		/// Called when the command is executed.
		/// </summary>
		protected abstract void OnExecute();
	}
}
