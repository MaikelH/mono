//
// System.CodeDom CodeExpression Class implementation
//
// Author:
//   Miguel de Icaza (miguel@ximian.com)
//
// (C) 2001 Ximian, Inc.
//

namespace System.CodeDom {

	public class CodeExpression {
		object userData;
		
		//
		// Constructors
		//
		public CodeExpression ()
		{
		}

		//
		// Properties
		//
		public object UserData {
			get {
				return userData;
			}

			set {
				userData = value;
			}
		}
	}
}
