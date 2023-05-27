using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.RJControls;
using NCalc;
using Ecuations;


namespace MetodoDeGaussSeidel
{
    public partial class GaussSeidel : Form
    {
        private int numEc = 2;
        private List<string> headerEc = new List<string>(new string[] { "x", "y", "z", "u", "v" });
        private List<string> headerEa = new List<string>(new string[] { "Ea(x)", "Ea(y)", "Ea(z)", "Ea(u)", "Ea(v)" });

        private List<RJTextBox> listTbEc;
        private List<RJTextBox> listTbVa;
        private List<Label> listLbEc;
        private List<Label> listLbVa;

        private Tokens tokens = new Tokens();
        private InfixToRpn infix = new InfixToRpn();
        private ResolveRpn rpn = new ResolveRpn();

        Dictionary<string, string> variable = new Dictionary<string, string>();
        Dictionary<string, string> variableAnt = new Dictionary<string, string>();
        Dictionary<string, string> variableError = new Dictionary<string, string>();

        public GaussSeidel()
        {
            InitializeComponent();
            InitializeCB();
            InitializeDataGrid();
            InitializeTb();
            InitializeDictionary();
        }

        public void InitializeDictionary()
        {
            variable.Add("x", "0");
            variable.Add("y", "0");
            variable.Add("z", "0");
            variable.Add("v", "0");
            variable.Add("u", "0");

            variableAnt.Add("x", "0");
            variableAnt.Add("y", "0");
            variableAnt.Add("z", "0");
            variableAnt.Add("v", "0");
            variableAnt.Add("u", "0");

            variableError.Add("x", "0");
            variableError.Add("y", "0");
            variableError.Add("z", "0");
            variableError.Add("v", "0");
            variableError.Add("u", "0");
        }

        public void InitializeDictionary(bool t)
        {
            variable["x"] = tbValueX.Texts;
            variable["y"] = tbValueY.Texts;
            variable["z"] = tbValueZ.Texts;
            variable["v"] = tbValueV.Texts;
            variable["u"] = tbValueU.Texts;

            variableError["x"] = "0";
            variableError["y"] = "0";
            variableError["z"] = "0";
            variableError["v"] = "0";
            variableError["u"] = "0";
        }

        public void InitializeTb()
        {
            listTbEc = new List<RJTextBox>(new RJTextBox[] { tbEcuX,tbEcuY,tbEcuZ,tbEcuU, tbEcuV });
            listTbVa = new List<RJTextBox>(new RJTextBox[] { tbValueX, tbValueY, tbValueZ, tbValueU, tbValueV });
            listLbEc = new List<Label>(new Label[] {lbEcX,lbEcY,lbEcZ, lbEcU, lbEcV });
            listLbVa = new List<Label>(new Label[] {lbValX,lbValY,lbValZ,lbValU,lbValV});


            for (int i = 0; i < 5; i++)
            {
                listTbEc[i].Visible = false;
                listTbVa[i].Visible = false;
                listLbEc[i].Visible = false;
                listLbVa[i].Visible = false;
            }

            for (int i = 0; i < numEc; i++)
            {
                listTbEc[i].Visible = true;
                listTbVa[i].Visible = true;
                listLbEc[i].Visible = true;
                listLbVa[i].Visible = true;
            }
        
        
        }

        public void InitializeCB()
        {
            cbNumEcuac.Items.AddRange(new string[] {"2","3","4","5"});
            cbNumEcuac.SelectedIndex = 1;
        }


        public void InitializeDataGrid()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("column1", "i");

            for(int i = 0; i < numEc; i++)
            {
                dataGridView1.Columns.Add($"column+{i}", headerEc[i]);
            }

            for (int i = 0; i <numEc; i++)
            {
                dataGridView1.Columns.Add($"columnB+{i}", headerEa[i]);
            }
        }



        private List<string> ecuations;
        private List<string> ecuationsV;

        bool firstTime = true;
        
        
        public void LlenarEcuaciones()
        {

            ecuations = new List<string>();
            

            for (int i = 0; i < numEc; i++)
            {
                ecuations.Add(listTbEc[i].Texts);
                variableAnt[headerEc[i]] = variable[headerEc[i]];
                
            }

            ecuationsV = ecuations;
        }

        public void RemplazarValores(int index)
        {
            for (int i = 0; i < numEc; i++)
            { 
                ecuationsV[index] = tokens.ParseVariable(headerEc[i], variable[headerEc[i]], ecuationsV[index]);
            }
        }

        public void ResolverEcuacion(int index)
        {
             List<string> list = tokens.Convert(ecuationsV[index]);
             Queue<string> queue = infix.Convert(list);
             string result = rpn.Convert(queue);

            Double dResult = Math.Round(double.Parse(result), 6);


             variable[headerEc[index]] = dResult.ToString();           
        }


        public string CalcularEa(int index)
        {
            double valAc = double.Parse(variable[headerEc[index]]);
            double valAn = double.Parse(variableAnt[headerEc[index]]);
            double Ea = ((valAc - valAn) / valAc) * 100;
            Ea = Math.Round(Math.Abs(Ea),2);


            variableError[headerEc[index]] = Ea.ToString();
            return Ea.ToString();
        }

        public void LlenarRowGrid(int row)
        {
            int column = 0;

            dataGridView1.Rows.Add();

            dataGridView1.Rows[row].Cells[column].Value = row.ToString();

            column++;

            for (int i = 0; i < numEc; i++)
            {
                dataGridView1.Rows[row].Cells[column].Value = variable[headerEc[i]];
                column++;
            }

            if(row == 0)
            {
                return;
            }

            for (int i = 0; i < numEc; i++)
            {
                dataGridView1.Rows[row].Cells[column].Value = CalcularEa(i);
                column++;
            }
        }

        public bool ErrorEstimado()
        {

            if (firstTime)
            {
                firstTime = false;
                return true;
            }

          
            for(int i = 0;i < numEc; i++)
            {
                if((double.Parse(variableError[headerEc[i]]) > double.Parse(tbEstimado.Texts)))
                {
                    return true;
                }
                
            }



            return false;
        }

        public void CalcularExpresion()
        {
            int j = 1;
            firstTime = true;
            InitializeDataGrid();

            InitializeDictionary(true);
            LlenarRowGrid(0);

            while (ErrorEstimado())
            {
                if(j > 1000)
                {
                    MessageBox.Show("No converge");
                    break;
                }


                LlenarEcuaciones();

                for (int i = 0; i < numEc; i++)
                {
                    RemplazarValores(i);
                    ResolverEcuacion(i);
                }

                LlenarRowGrid(j);

                j++;
            }        
            
        }

        private void cbNumEcuac_SelectedIndexChanged(object sender, EventArgs e)
        {
            numEc = int.Parse(cbNumEcuac.Text);
            InitializeTb();
            InitializeDataGrid();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                CalcularExpresion();
            }
            catch (Exception ex)
            {
                if(dataGridView1.Rows.Count> 3)
                {
                    MessageBox.Show("No converge");
                    return;
                }
                MessageBox.Show("la cadena es incorrecta");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for(int i = 0; i < 5; i++)
            {
                listTbEc[i].Texts = "";
                listTbVa[i].Texts = "";
                
            }
            tbEstimado.Texts = "";
        }
    }
}
