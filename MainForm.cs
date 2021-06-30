using DbFirstTest.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace DbFirstTest
{
    public partial class MainForm : Form
    {
        public ModelContext context;
        public string SelectedNode;
        public MainForm()
        {
            InitializeComponent();
            context = new ModelContext();
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView.SelectedNode = e.Node;

            if (e.Node.Text.EndsWith(")"))
                SelectedNode = e.Node.Text.TrimEnd('ш', 'т', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ')', ' ').TrimEnd('(').TrimEnd(' ');
            else
                SelectedNode = e.Node.Text.TrimEnd(' ');
        }

        private void DeleteComponents(string name) // Удаление компонентов
        {
            var deleteComponent = context.Component.Where(x => x.Name == name).FirstOrDefault();

            var includeComponent = context.Relations.Where(x => x.ChildId == deleteComponent.Id).ToList();

            if (includeComponent.Count > 1) // Есть ли данный компонент в составе другого компонента
            {// есть
                context.Relations.Remove(includeComponent.Where(x => x.ParentId == context.Relations.Where(c => c.ChildId == deleteComponent.Id).FirstOrDefault().ParentId).FirstOrDefault());
            }
            else
            {// нет
                var deleteChildRelations = context.Relations.Where(x => x.ParentId == deleteComponent.Id).ToList();

                foreach (var item in deleteChildRelations)
                {
                    DeleteComponents(context.Component.Where(x => x.Id == item.ChildId).FirstOrDefault().Name);
                }

                var childRelations = context.Relations.Where(x => x.ChildId == deleteComponent.Id).FirstOrDefault();

                if (childRelations != null)
                    context.Relations.Remove(childRelations);
                context.Component.Remove(deleteComponent);
            }
        }

        public TreeNode[] CreateChildTreeNode(int id) // Метод добавления дочерних узлов id - id родительского компонента
        {
            List<Relations> child = context.Relations.Where(x => x.ParentId == id).ToList();

            TreeNode[] nodes = new TreeNode[child.Count()];

            for (int i = 0; i < child.Count(); i++)
            {
                var component = context.Component.Find(child[i].ChildId);

                var querry = context.Relations.Where(x => x.ParentId == component.Id).FirstOrDefault(); // проверка есть ли вложенный элемент
                if (querry != null) // Если есть вложенный элемент
                {
                    TreeNode parentNode = new TreeNode($"{component.Name} ({context.Relations.Where(x => (x.ChildId == component.Id) && (x.ParentId == id)).FirstOrDefault().QuantityOfComponents} шт)");
                    parentNode.Nodes.AddRange(CreateChildTreeNode(component.Id));
                    nodes[i] = parentNode;
                }
                else // Если нет вложенного элемента
                    nodes[i] = new TreeNode($"{component.Name} ({context.Relations.Where(x => x.ChildId == component.Id).FirstOrDefault().QuantityOfComponents} шт)");
            }

            return nodes;
        }

        public void DisplayTreeView() // Метод отображения treeview
        {
            var idOfMainNodes = context.Relations.Where(x => x.ParentId == null).Select(x => x.ChildId).ToList();

            List<Component> allParentNodes = context.Component.Where(x => idOfMainNodes.Contains(x.Id)).ToList();

            foreach (var obj in allParentNodes)
            {
                TreeNode parentNode = new TreeNode(obj.Name);
                parentNode.Nodes.AddRange(CreateChildTreeNode(obj.Id));
                treeView.Nodes.Add(parentNode);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayTreeView();
        }

        private void NewParentComponent_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewParentComponentCreate NewParentComponentCreate_form = new NewParentComponentCreate(context);
            NewParentComponentCreate_form.ShowDialog();

            if (NewParentComponentCreate_form.Title != null)
                treeView.Nodes.Add(NewParentComponentCreate_form.Title);
            
        }

        private void NewChildComponent_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                NewComponentCreate newComponentCreate_form = new NewComponentCreate(context, SelectedNode);
                newComponentCreate_form.ShowDialog();

                treeView.Nodes.Clear();
                DisplayTreeView();
                treeView.ExpandAll();
            }
            else
                MessageBox.Show("Вложенный компонент можно создать только в компоненте верхнего уровня", "Ошибка", MessageBoxButtons.OK);
        }

        private void RenameComponent_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameComponent renameComponent_form = new RenameComponent(context, SelectedNode);
            renameComponent_form.ShowDialog();

            treeView.Nodes.Clear();
            DisplayTreeView();
            treeView.ExpandAll();
        }

        private void DeleteComponent_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteComponents(SelectedNode);

            context.SaveChanges(); 

            treeView.Nodes.Clear();
            DisplayTreeView();
            treeView.ExpandAll();
        }

        private void CreateReport_ToolStripMenuItem_Click(object sender, EventArgs e)
        {



            var application = new Word.Application();

            Word.Document document = application.Documents.Add();


        }
    }
}
