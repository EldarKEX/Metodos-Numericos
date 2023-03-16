using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodo_de_biseccion
{
    public partial class Biseccion : Form
    {
        public Biseccion()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                OperacionesMatematicas operaciones = new OperacionesMatematicas();
                if (!operaciones.ValidarParentesis(tbOperacion.Text))
                {
                    MessageBox.Show("pARENTESIS iNVALIDOS");
                }
                (int, int) pos = operaciones.SubstringParentesis(tbOperacion.Text);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
