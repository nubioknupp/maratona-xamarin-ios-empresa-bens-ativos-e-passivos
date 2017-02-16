// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace EmpresaBensAtivosPassivos
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UITextField bancoTextField { get; set; }

		[Outlet]
		UIKit.UITextField caixaTextField { get; set; }

		[Outlet]
		UIKit.UITextField emprestimoTextField { get; set; }

		[Outlet]
		UIKit.UITextField fornecedorTextField { get; set; }

		[Outlet]
		UIKit.UITextField pagarTextField { get; set; }

		[Outlet]
		UIKit.UITextField receberTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (caixaTextField != null) {
				caixaTextField.Dispose ();
				caixaTextField = null;
			}

			if (bancoTextField != null) {
				bancoTextField.Dispose ();
				bancoTextField = null;
			}

			if (receberTextField != null) {
				receberTextField.Dispose ();
				receberTextField = null;
			}

			if (emprestimoTextField != null) {
				emprestimoTextField.Dispose ();
				emprestimoTextField = null;
			}

			if (fornecedorTextField != null) {
				fornecedorTextField.Dispose ();
				fornecedorTextField = null;
			}

			if (pagarTextField != null) {
				pagarTextField.Dispose ();
				pagarTextField = null;
			}
		}
	}
}
