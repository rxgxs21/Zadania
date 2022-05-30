using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DataGrindView
{
    public partial class Form1 : Form
    {
        public DataTable dt = new DataTable();
        int Id; //Row ID
        int currentCellValue; //Save value of cell if it needs to be recovered
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when Form1 is being loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            displayGird();
        }

        /// <summary>
        /// Occurs when Save button is clicked. Adds new row to DataGridView with values from A-D text boxes.
        /// Shows message box with an error message if data is invalid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            {
                if (textBoxA.Text == "" || !int.TryParse(textBoxA.Text, out i) || textBoxB.Text == "" || !int.TryParse(textBoxB.Text, out i) || textBoxC.Text == "" || !int.TryParse(textBoxC.Text, out i) || textBoxD.Text == "" || !int.TryParse(textBoxD.Text, out i))
                {
                    MessageBox.Show("Nie poprawny format danych!");
                }
                else
                {
                    if (Int32.Parse(textBoxA.Text) < 0 || Int32.Parse(textBoxA.Text) > 1000 || Int32.Parse(textBoxB.Text) < 0 || Int32.Parse(textBoxB.Text) > 1000 || Int32.Parse(textBoxC.Text) < 0 || Int32.Parse(textBoxC.Text) > 1000 || Int32.Parse(textBoxD.Text) < 0 || Int32.Parse(textBoxD.Text) > 1000)
                    {
                        MessageBox.Show("Wybierz liczby z przedziału 0-1000!");
                    }
                    else
                    {
                        DataRow dr = dt.NewRow();
                        dr[0] = Int32.Parse(textBoxA.Text);
                        dr[1] = Int32.Parse(textBoxB.Text);
                        dr[2] = Int32.Parse(textBoxC.Text);
                        dr[3] = Int32.Parse(textBoxD.Text);
                        dt.Rows.Add(dr);
                        afterChange();
                    }
                }
            }

        }

        /// <summary>
        /// Occurs when Delete button is clicked. Deletes row from DataGridView which was picked by double-click.
        /// Shows message box with an error message if row was not picked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                dataGridABCD.Rows.RemoveAt(Id);
                afterChange();
            }
            else
            {
                MessageBox.Show("Nie wybrano wiersza!\n Wiersz mozesz wybrac klikajac go dwukrotnie.");
            }


        }

        /// <summary>
        /// Occurs when Update button is clicked. Updates row in DataGridView which was picked by double-click with values from A-D text boxes.
        /// Shows message box with an error message if row was not picked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                dataGridABCD.Rows[Id].Cells[0].Value = textBoxA.Text;
                dataGridABCD.Rows[Id].Cells[1].Value = textBoxB.Text;
                dataGridABCD.Rows[Id].Cells[2].Value = textBoxC.Text;
                dataGridABCD.Rows[Id].Cells[3].Value = textBoxD.Text;
                afterChange();
            }
            else
            {
                MessageBox.Show("Nie wybrano wiersza!\n Wiersz mozesz wybrac klikajac go dwukrotnie.");
            }

        }

        /// <summary>
        /// Occurs when row in DataGirdView was double-clicked. Fills A-D text boxes with values from picked row and set Id value with picked row's Id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridABCD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxA.Text = dataGridABCD.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxB.Text = dataGridABCD.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxC.Text = dataGridABCD.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxD.Text = dataGridABCD.Rows[e.RowIndex].Cells[3].Value.ToString();
            Id = e.RowIndex;
        }

        /// <summary>
        /// Occurs when ctrl + e was clicked. Shows new form that lets edit value of selected cells.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.E))
            {
                using (Form2 form = new Form2() { })
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        int s = 0;
                        if (Int32.TryParse(form.value, out s))
                        {
                            if (Int32.Parse(form.value) < 0 || Int32.Parse(form.value) > 1000)
                            {
                                MessageBox.Show("Wybierz liczbę z przedziału 0-1000!");
                            }
                            else
                            {
                                foreach (DataGridViewCell cell in dataGridABCD.SelectedCells)
                                {
                                    if (cell.RowIndex != 0)
                                    {
                                        cell.Value = form.value;
                                    }
                                }
                                afterChange();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Niepoprawny format!");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Occurs when user ends editing single cell.
        /// Shows message box with an error message if user types wrong value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridABCD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Int32.Parse(dataGridABCD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) < 0 || Int32.Parse(dataGridABCD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) > 1000)
            {
                MessageBox.Show("Wybierz liczbę z przedziału 0-1000!");
                dataGridABCD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = currentCellValue;
            }
            else
            {
                afterChange();
            }
        }

        /// <summary>
        /// Occurs when user starts editing single cell. Saves backup value of cell.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridABCD_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            currentCellValue = Int32.Parse(dataGridABCD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }

        //Methods
        
        /// <summary>
        /// Sets and adds columns and row with totals to DataGridView.
        /// </summary>
        private void displayGird()
        {
            dt.Columns.Add("A");
            dt.Columns.Add("B");
            dt.Columns.Add("C");
            dt.Columns.Add("D");

            DataRow dr = dt.NewRow();
            dr[0] = sum(0);
            dr[1] = sum(1);
            dr[2] = sum(2);
            dr[3] = sum(3);
            dt.Rows.Add(dr);
            dataGridABCD.DataSource = dt;
            dataGridABCD.Rows[0].ReadOnly = true;
            dataGridABCD.Rows[0].DefaultCellStyle.BackColor = Color.DarkGray;
        }

        /// <summary>
        /// Calculate total of values in given column.
        /// </summary>
        /// <param name="column">Index of cloumn</param>
        /// <returns>(int)Total of values in column</returns>
        private int sum(int column)
        {
            int sum = 0;
            foreach (DataRow item in dt.Rows)
            {
                if (dt.Rows.IndexOf(item) != 0)
                {
                    sum += Int32.Parse(item[column].ToString());
                }
            }
            return sum;
        }
        /// <summary>
        /// Update row with totals.
        /// </summary>
        private void afterChange()
        {
            dt.Rows[0][0] = sum(0);
            dt.Rows[0][1] = sum(1);
            dt.Rows[0][2] = sum(2);
            dt.Rows[0][3] = sum(3);
            emptyTextBoxes();
        }

        /// <summary>
        /// Clears A-D text boxes.
        /// </summary>
        private void emptyTextBoxes()
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
            textBoxD.Text = "";
        }
    }
}