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
// Copyright (c) 2004 Novell, Inc.
//
// Authors:
//	Peter Bartok	pbartok@novell.com
//
//
// $Log: AccessibleObject.cs,v $
// Revision 1.2  2004/08/11 13:44:33  pbartok
// - Fixed to match ControlCollection rewrite
//
// Revision 1.1  2004/07/09 05:21:25  pbartok
// - Initial check-in
//
//

// NOT COMPLETE

using Accessibility;
using System.Drawing;
using System.Globalization;
using System.Reflection;

namespace System.Windows.Forms {
	public class AccessibleObject : MarshalByRefObject, IReflect, IAccessible {
		#region Private Variables
		private string		name;
		private string		value;
		private Control		owner;
		internal AccessibleRole	role;
		internal string		default_action;
		internal string		description;
		internal string		help;
		internal string		keyboard_shortcut;
		#endregion	// Private Variables

		#region Public Constructors
		public AccessibleObject() {
			this.owner=null;
			this.value=null;
			this.name=null;
			this.role=AccessibleRole.Default;
			this.default_action=null;
			this.description=null;
			this.help=null;
			this.keyboard_shortcut=null;
		}
		#endregion	// Public Constructors

		#region Private Constructors
		internal AccessibleObject(Control owner) : this () {
			this.owner=owner;
		}
		#endregion	// Private Constructors

		#region Public Instance Properties
		public virtual Rectangle Bounds {
			get {
				return Rectangle.Empty;
			}
		}

		public virtual string DefaultAction {
			get {
				return default_action;
			}
		}

		public virtual string Description {
			get {
				return description;
			}
		}

		public virtual string Help {
			get {
				return help;
			}
		}

		public virtual string KeyboardShortcut {
			get {
				return keyboard_shortcut;
			}
		}

		public virtual string Name {
			get {
				return name;
			}

			set {
				name=value;
			}
		}

		public virtual AccessibleObject Parent {
			get {
				if ((owner!=null) && (owner.Parent!=null)) {
					return owner.Parent.AccessibilityObject;
				}
				return null;
			}
		}

		public virtual AccessibleRole Role {
			get {
				return role;
			}
		}

		public virtual AccessibleStates State {
			get {
				AccessibleStates	state=AccessibleStates.None;

				if (owner!=null) {
					if (owner.Focused) {
						state |= AccessibleStates.Focused;
					}

					if (!owner.Visible) {
						state |= AccessibleStates.Invisible;
					}
				}
				return state;
			}
		}

		public virtual string Value {
			get {
				return this.value;
			}

			set {
				this.value=value;
			}
		}
		#endregion	// Public Instance Properties

		#region Public Instance Methods
		public virtual void DoDefaultAction() {
			if (owner!=null) {
				owner.DoDefaultAction();
			}
		}

		public virtual AccessibleObject GetChild(int index) {
			if (owner!=null) {
				if (index<owner.child_controls.Count) {
					return owner.child_controls[index].AccessibilityObject;
				}
			}
			return null;
		}

		public virtual int GetChildCount() {
			if (owner!=null) {
				return owner.child_controls.Count;
			}
			return -1;
		}
		#endregion	// Public Instance Methods

		#region	IReflection Methods and Properties
		FieldInfo IReflect.GetField(String name, BindingFlags bindingAttr) {
			throw new NotImplementedException();
		}       

		FieldInfo[] IReflect.GetFields(BindingFlags bindingAttr) {
			throw new NotImplementedException();
		}    

		MemberInfo[] IReflect.GetMember(String name, BindingFlags bindingAttr) {
			throw new NotImplementedException();
		}

		MemberInfo[] IReflect.GetMembers(BindingFlags bindingAttr) {
			throw new NotImplementedException();
		}

		MethodInfo IReflect.GetMethod(String name, BindingFlags bindingAttr) {
			throw new NotImplementedException();
		}

		MethodInfo IReflect.GetMethod(String name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) {
			throw new NotImplementedException();
		}

		MethodInfo[] IReflect.GetMethods(BindingFlags bindingAttr) {
			throw new NotImplementedException();
		}

		PropertyInfo IReflect.GetProperty(String name, BindingFlags bindingAttr) {
			throw new NotImplementedException();
		}

		PropertyInfo IReflect.GetProperty(String name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) {
			throw new NotImplementedException();
		}

		PropertyInfo[] IReflect.GetProperties(BindingFlags bindingAttr) {
			throw new NotImplementedException();
		}

		Object IReflect.InvokeMember(String name, BindingFlags invokeAttr, Binder binder, Object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) {
			throw new NotImplementedException();
		}

		Type IReflect.UnderlyingSystemType {
			get {
				throw new NotImplementedException();
			}
		}
		#endregion	// IReflection Methods and Properties

		#region IAccessible Methods and Properties
		void IAccessible.accDoDefaultAction(object childID) {
			throw new NotImplementedException();
		}

		int IAccessible.accChildCount {
			get {
				throw new NotImplementedException();
			}
		}

		object IAccessible.accFocus {
			get {
				throw new NotImplementedException();
			}
		}

		object IAccessible.accHitTest(int xLeft, int yTop) {
			throw new NotImplementedException();
		}

		void IAccessible.accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object childID) {
			throw new NotImplementedException();
		}

		object IAccessible.accNavigate(int navDir, object childID) {
			throw new NotImplementedException();
		}

		object IAccessible.accParent {
			get {
				throw new NotImplementedException();
			}
		}

                void IAccessible.accSelect(int flagsSelect, object childID) {
			throw new NotImplementedException();
                }

                object IAccessible.accSelection {
                        get {
				throw new NotImplementedException();
			}
		}

		object IAccessible.get_accChild(object childID) {
			throw new NotImplementedException();
		}

		string IAccessible.get_accDefaultAction(object childID) {
			throw new NotImplementedException();
		}

		string IAccessible.get_accDescription(object childID) {
			throw new NotImplementedException();
		}

		string IAccessible.get_accHelp(object childID) {
			throw new NotImplementedException();
		}

		int IAccessible.get_accHelpTopic(out string pszHelpFile,object childID) {
			throw new NotImplementedException();
		}

		string IAccessible.get_accKeyboardShortcut(object childID) {
			throw new NotImplementedException();
		}

		string IAccessible.get_accName(object childID) {
			throw new NotImplementedException();
		}

		object IAccessible.get_accRole(object childID) {
			throw new NotImplementedException();
		}

		object IAccessible.get_accState(object childID) {
			throw new NotImplementedException();
		}

		string IAccessible.get_accValue(object childID) {
			throw new NotImplementedException();
		}

		void IAccessible.set_accName(object childID, string newName) {
			throw new NotImplementedException();
		}

		void IAccessible.set_accValue(object childID, string newValue) {
			throw new NotImplementedException();
                }
		#endregion	// IAccessible Methods and Properties
	}
}
