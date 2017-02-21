using System;
using System.Globalization;
using UIKit;

namespace EmpresaBensAtivosPassivos
{
    public partial class PatrimonioViewController : UIViewController
    {
        public double Patrimonio { private get; set; }

        public PatrimonioViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            patrimonioTextField.Text = Patrimonio.ToString(CultureInfo.CurrentCulture);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

