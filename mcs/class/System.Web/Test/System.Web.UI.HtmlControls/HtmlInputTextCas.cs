//
// HtmlInputTextCas.cs 
//	- CAS unit tests for System.Web.UI.HtmlControls.HtmlInputText
//
// Author:
//	Sebastien Pouliot  <sebastien@ximian.com>
//
// Copyright (C) 2005 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using NUnit.Framework;

using System;
using System.Security.Permissions;
using System.Web.UI.HtmlControls;

using MonoTests.System.Web.UI.HtmlControls;

namespace MonoCasTests.System.Web.UI.HtmlControls {

	[TestFixture]
	[Category ("CAS")]
	public class HtmlInputTextCas : AspNetHostingMinimal {

		[Test]
		[PermissionSet (SecurityAction.Deny, Unrestricted = true)]
		public void Deny_Unrestricted ()
		{
			HtmlInputTextTest unit = new HtmlInputTextTest ();
			unit.ConstructorType ();
			unit.DefaultProperties ();
			unit.CleanProperties ();
			unit.NullProperties ();
			unit.Password ();
			unit.RenderAttributes ();
			unit.RenderAttributes_Password ();
			unit.IPostBackDataHandler_RaisePostBackEvent ();
			unit.IPostBackDataHandler_LoadPostData ();
#if NET_2_0
			unit.RaisePostBackEvent ();
			unit.LoadPostData ();
#endif
		}

		public override Type Type {
			get { return typeof (HtmlInputText); }
		}
	}
}
