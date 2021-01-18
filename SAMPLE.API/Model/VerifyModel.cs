using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAMPLE.API.Model
{
	public class VerifyModel
	{
		public VerifyModel(bool Verify, string Token)
		{
			this.Verify = Verify;
			this.Token = Token;
		}
		public bool Verify { get; set; }
		public string Token { get; set; }
	}
}
