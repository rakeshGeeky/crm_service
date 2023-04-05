﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyServiceSchema

	/// <exclude/>
	public class UsrRealtyServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyServiceSchema(UsrRealtyServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f968a2a5-8f69-4712-b104-d4f8b8d6256c");
			Name = "UsrRealtyService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b9510dc5-648b-41d0-be0f-dff718daf5ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,77,111,219,48,12,61,187,191,66,240,201,6,50,99,187,174,235,128,100,75,138,12,72,19,212,41,114,8,118,80,108,38,21,38,75,46,69,101,51,214,254,247,202,146,147,217,216,144,98,7,127,145,143,143,143,143,130,21,175,192,212,188,0,182,6,68,110,244,158,178,47,90,237,197,193,34,39,161,21,187,186,250,237,174,200,26,161,14,44,111,12,65,149,229,128,71,81,192,66,151,32,175,47,102,179,13,236,222,64,140,11,18,71,223,171,7,236,171,65,200,190,78,254,153,115,228,46,95,85,131,210,208,227,239,166,45,56,7,99,92,163,156,56,129,71,108,59,41,110,102,66,94,208,119,31,28,155,250,14,200,49,215,78,215,78,72,65,205,61,60,89,129,80,129,34,147,244,63,218,33,216,13,123,163,164,69,101,93,160,76,125,151,218,238,164,40,88,33,185,49,236,30,184,164,166,19,195,62,178,9,55,208,125,141,216,220,101,203,165,146,77,95,126,75,225,55,19,109,151,53,132,101,13,166,136,182,110,226,185,58,234,31,144,44,128,30,117,233,100,198,171,101,190,142,71,108,162,203,38,167,70,182,210,29,108,225,136,249,1,206,209,108,131,188,174,161,28,121,162,168,21,14,134,102,26,43,78,131,138,16,202,190,25,173,70,110,8,83,107,101,224,50,206,79,207,60,113,103,65,9,133,168,184,100,183,64,107,77,92,142,43,109,21,77,154,117,83,195,188,76,12,97,187,70,244,22,133,216,136,13,130,203,253,30,48,100,82,79,28,140,137,196,158,117,213,217,220,220,89,41,151,56,173,106,106,146,62,87,202,158,159,217,5,84,159,60,176,159,232,35,4,178,168,216,187,15,215,33,240,18,30,167,121,16,140,149,173,15,239,187,124,14,18,10,98,38,60,110,152,130,159,44,196,146,7,3,232,214,167,220,187,91,100,215,39,114,167,91,218,74,37,51,171,138,44,183,85,18,63,24,92,161,59,21,113,122,198,204,80,135,68,56,68,241,57,177,121,4,4,159,9,242,227,212,13,56,125,178,92,38,129,55,91,113,116,63,0,2,76,90,41,183,86,148,67,107,254,52,25,171,210,51,245,220,248,15,186,129,135,39,78,110,186,225,59,119,206,118,5,127,178,233,47,40,44,65,94,112,201,241,83,103,234,231,36,61,195,189,249,161,42,196,188,255,237,237,133,189,2,169,206,7,166,217,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f968a2a5-8f69-4712-b104-d4f8b8d6256c"));
		}

		#endregion

	}

	#endregion

}

