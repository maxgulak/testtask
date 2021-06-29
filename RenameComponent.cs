using DbFirstTest.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DbFirstTest
{
    public partial class RenameComponent : Form
    {
        public ModelContext _context;
        public string _node;
        public RenameComponent(ModelContext context, string node)
        {
            InitializeComponent();
            _context = context;
            _node = node;
        }

        private void RenameComponent_button_Click(object sender, EventArgs e)
        {
            string newName = newNameOfComponent_textBox.Text;

            if(newName != "")
            {
                var checkAvailable = _context.Component.Where(x => x.Name == newName).FirstOrDefault();
                
                if (checkAvailable == null)
                {
                    var component = _context.Component.Where(x => x.Name == _node).FirstOrDefault();
                    component.Name = newName;

                    _context.SaveChanges();
                    Close();
                }
                else
                    MessageBox.Show("Компонент с данным именем уже существует, выберите другое имя", "Ошибка", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Необходимо ввести новое имя", "Ошибка", MessageBoxButtons.OK);

            newNameOfComponent_textBox.Text = "";
        }
    }
}
