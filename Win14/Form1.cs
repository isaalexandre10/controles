using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win14 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e) {
            webBrowser.Url = new Uri(txtURL.Text);
        }

        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e) {
            //Define o valor máximo do componente ProgressBar para ser igual ao do argumento do evento.
            this.progressBar.Maximum = (int)e.MaximumProgress;

            //Além de valores como 10000, você poderá receber -1, então aqui vamos tratar esta situação.
            if (e.CurrentProgress > -1) {
                //Com o valor máximo definido o ProgressBar irá preencher sua barra conforme a relação entre CurrentProgress e MaximumProgress.
                this.progressBar.Value = (int)e.CurrentProgress;
            }
        }
    }
}
