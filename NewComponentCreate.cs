using DbFirstTest.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DbFirstTest
{
    public partial class NewComponentCreate : Form
    {
        public string Title { get; set; }
        public byte Quantity { get; set; }
        public ModelContext _context;
        public string _node;
        public NewComponentCreate(ModelContext context, string node)
        {
            InitializeComponent();
            _context = context;
            _node = node;
        }

        private bool IsListRecursion(List<Relations> relations, bool flag)
        {
            foreach (var item in relations) // Проверяем дочерние узлы
            {
                var component = _context.Component.Where(x => x.Id == item.ChildId).FirstOrDefault();

                if (component.Name.TrimEnd(' ') != _node)
                {
                    var querry = _context.Relations.Where(x => x.ParentId == component.Id).ToList();

                    if (querry != null)
                    {
                        flag = IsListRecursion(querry, flag);
                        if (flag == true)
                            break;
                    }

                }
                else
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        private void CreateNewComponent_button_Click(object sender, EventArgs e)
        {
            Title = nameOfNewComponent_textBox.Text;
            if (Title.Length < 26)
            {
                if (String.IsNullOrWhiteSpace(Title) == false)
                {
                    if (short.TryParse(numberOfNewComponent_textBox.Text, out short a) && a > 0 && a < 256)
                    {
                        Quantity = byte.Parse(numberOfNewComponent_textBox.Text);


                        var querry = _context.Component.Where(x => x.Name == Title).FirstOrDefault(); // Выбор компонента с заданным именем
                        if (querry == null) // Если компонента с таким именем нет
                        { // Создаём новый компонент и задаём отношение
                            Component component = new Component();
                            component.Name = Title;
                            _context.Component.Add(component);

                            _context.SaveChanges();

                            Relations relation = new Relations();
                            relation.ChildId = component.Id;
                            relation.ParentId = _context.Component.Where(x => x.Name == _node).FirstOrDefault().Id;
                            relation.QuantityOfComponents = Quantity;
                            _context.Relations.Add(relation);

                            _context.SaveChanges();
                            Close();
                        }
                        else // Если компонент с таким именем есть
                        { // Задаём только отношение
                            if (_context.Relations.Where(x => x.ParentId == querry.Id).FirstOrDefault() != null) // Проверка на существование этого комнонента
                            {
                                var checkId = _context.Component.Where(x => x.Name == Title).FirstOrDefault().Id; // Проверяем ссылается ли добавляемый элемент на родительский

                                bool flag = false;

                                flag = IsListRecursion(_context.Relations.Where(x => x.ParentId == checkId).ToList(), flag);

                                if (flag == false)
                                {
                                    Relations relation = new Relations();
                                    relation.ChildId = querry.Id;
                                    relation.ParentId = _context.Component.Where(x => x.Name == _node).FirstOrDefault().Id;
                                    relation.QuantityOfComponents = Quantity;
                                    _context.Relations.Add(relation);

                                    _context.SaveChanges();
                                    Close();
                                }
                                else
                                    MessageBox.Show("Рекурсивное вложение компонентов не допускается", "Ошибка", MessageBoxButtons.OK);
                            }
                            else
                                MessageBox.Show("Компонент с таким именем уже существует", "Ошибка", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Количество компонентов - это любое число от 1 до 255", "Ошибка", MessageBoxButtons.OK);
                        numberOfNewComponent_textBox.Text = "";
                    }
                }
                else
                    MessageBox.Show("Необходимо ввести наименование", "Ошибка", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Максимальная длина названия - 25 символов", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
