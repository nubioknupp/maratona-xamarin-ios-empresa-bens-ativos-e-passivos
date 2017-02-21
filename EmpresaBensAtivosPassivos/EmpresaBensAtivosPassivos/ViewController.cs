using System;
using Foundation;
using UIKit;

namespace EmpresaBensAtivosPassivos
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier.Equals("PatrimonioSegueId"))
            {
                var patrimonio = segue.DestinationViewController as PatrimonioViewController;

                if (patrimonio != null)
                {
                    patrimonio.Patrimonio = CalculaPatrimonio();
                }
            }

            base.PrepareForSegue(segue, sender);
        }

        private double CalculaPatrimonio()
        {
            var banco = !string.IsNullOrEmpty(bancoTextField.Text) ? bancoTextField.Text : "0";
            var caixa = !string.IsNullOrEmpty(caixaTextField.Text) ? caixaTextField.Text : "0";
            var receber = !string.IsNullOrEmpty(receberTextField.Text) ? receberTextField.Text : "0";
            var pagar = !string.IsNullOrEmpty(pagarTextField.Text) ? pagarTextField.Text : "0";
            var fornecedor = !string.IsNullOrEmpty(fornecedorTextField.Text) ? fornecedorTextField.Text : "0";
            var emprestimo = !string.IsNullOrEmpty(emprestimoTextField.Text) ? emprestimoTextField.Text : "0";

            var ativos = Convert.ToDouble(banco) + Convert.ToDouble(caixa) + Convert.ToDouble(receber);
            var passivos = Convert.ToDouble(pagar) + Convert.ToDouble(fornecedor) + Convert.ToDouble(emprestimo);

            return ativos - passivos;
        }


    }
}