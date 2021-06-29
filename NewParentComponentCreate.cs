using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DbFirstTest.Model;

namespace DbFirstTest
{
    public partial class NewParentComponentCreate : Form
    {
        public string Title { get; set; }
        public ModelContext _context;
        public NewParentComponentCreate(ModelContext context)
        {
            InitializeComponent();
            _context = context;
        }
        
        private void CreateNewParentComponent_button_Click(object sender, EventArgs e)
        {
            Title = nameOfNewParentComponent_textBox.Text;
            
            if (Title != "") // Проверка на пустой ввод 
            {
                var querry = _context.Component.Where(x => x.Name == Title).FirstOrDefault(); // Выбор компонента с заданным именем
                if (querry == null) // Если такого компонента не существует
                    Close();
                else // Если такой компоненент существует
                    MessageBox.Show("Запись с таким именем уже существует", "Ошибка", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Необходимо ввести наименование", "Ошибка", MessageBoxButtons.OK);

            nameOfNewParentComponent_textBox.Text = ""; 
        }
    }
}
