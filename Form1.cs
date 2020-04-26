using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat__Windows_Forms_App_
{
    public partial class Form1 : Form
    {
        private List<Student> listaStudenata { get; set; }
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            ListBoxSetUp();
            DataGridViewSetUp();
        }
        private void ListBoxSetUp()
        {
            listBox1.AccessibleName = "ListBox";

            Array enums = Enum.GetValues(typeof(StudProgram.StudiskiProgram));
            foreach (var item in enums)
            {
                listBox1.Items.Add(item);
            }
        }
        private void DataGridViewSetUp()
        {
            DataGridViewTextBoxColumn kolona = new DataGridViewTextBoxColumn();
            kolona.DataPropertyName = "ID";
            kolona.Name = "Id";
            dataGridView1.Columns.Add(kolona);

            DataGridViewTextBoxColumn kolona1 = new DataGridViewTextBoxColumn();
            kolona1.DataPropertyName = "Ime";
            kolona1.Name = "Ime";
            dataGridView1.Columns.Add(kolona1);

            DataGridViewTextBoxColumn kolona2 = new DataGridViewTextBoxColumn();
            kolona2.DataPropertyName = "Prezime";
            kolona2.Name = "Prezime";
            dataGridView1.Columns.Add(kolona2);

            DataGridViewTextBoxColumn kolona3 = new DataGridViewTextBoxColumn();
            kolona3.DataPropertyName = "Godine";
            kolona3.Name = "Godine";
            dataGridView1.Columns.Add(kolona3);

            DataGridViewTextBoxColumn kolona4 = new DataGridViewTextBoxColumn();
            kolona4.DataPropertyName = "StudiskiProgram";
            kolona4.Name = "Studiski Program";
            dataGridView1.Columns.Add(kolona4);

            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            listaStudenata = new List<Student>();
        }
        private void DataGridViewRefresh()
        {
            bindingSource = new BindingSource();
            foreach (var student in listaStudenata)
            {
                bindingSource.Add(new StudentModel(student));
            }
            dataGridView1.DataSource = bindingSource;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StudProgram student = new StudProgram((Student.StudiskiProgram)listBox1.SelectedItem);
            student.Ime = textBox1.Text;
            student.Prezime = textBox2.Text;
            student.Godine = (int)numericUpDown1.Value;
            listaStudenata.Add(student);
            DataGridViewRefresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor projekta: Dejan Puđa - IT 20/19", "Autor!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0];
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
            var iD = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            if (iD < 0) return;
            Student student = listaStudenata.Where(Student => Student.Id == iD).FirstOrDefault();

            MessageBox.Show(student.ToString());
        }
    }
}
