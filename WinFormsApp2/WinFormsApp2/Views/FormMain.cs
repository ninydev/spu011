using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Models;

namespace WinFormsApp2.Views
{
    public partial class FormMain : Form
    {
        public static Data.ApplicationDbContext db = new Data.ApplicationDbContext();
        public FormMain()
        {
            InitializeComponent();
            // this.lstGroups.DataSource = db.Groups;
            this.LoadGroupsToListBox();
        }

        private void LoadGroupsToListBox()
        {
            lstGroups.Items.Clear();

            // Явная загрузка всех сущностей с отношениями
            // var grups = db.Groups.Include(g => g.Students);
            // lstGroups.Items.AddRange(grups.ToArray());

            var grups = db.Groups; // .Include(g => g.Students);
            lstGroups.Items.AddRange(grups.ToArray());


            // Загрузка только сущностей групп
            // lstGroups.Items.AddRange(db.Groups.ToArray());
        }





        private void btnCreateForm_Click(object sender, EventArgs e)
        {
            //Form f = new Form();

            //Button btn = new Button();
            //btn.Text = "Я создал кнопку в другой форме";
            //btn.Click += (object sender, EventArgs e) =>
            //    {
            //        f.Close();
            //    };

            //f.Controls.Add(btn);
            //f.ShowDialog();
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();
            f.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormGroup grp = new FormGroup();
            if(grp.ShowDialog() == DialogResult.OK)
            {
                Group g = new() { Name = grp.txtName.Text };
                try
                {
                    db.Add(g);
                    db.SaveChanges();
                }
                catch(Microsoft.EntityFrameworkCore.DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message, "Create Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Create Error Other", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadGroupsToListBox();
            }
        }

        Group selectedGroup = null;
        private void lstGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteStudent.Enabled = false;
            selectedGroup = (Group) (sender as ListBox).SelectedItem;
            LoadStudentToListBox();
            // MessageBox.Show((sender as ListBox).SelectedItem.ToString());
        }

        private void LoadStudentToListBox()
        {
            lstStudents.Items.Clear();
            // Явная загрузка коллекции - по мере необходимости в данных
            // db.Entry(selectedGroup).Collection(p => p.Students).Load();
            lstStudents.Items.AddRange(selectedGroup.Students.ToArray());
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent();
            if(formStudent.ShowDialog() == DialogResult.OK)
            {
                Student newStudent = new() { 
                    Name = formStudent.txtName.Text, 
                    Email = formStudent.txtEmail.Text,
                    Avatar = formStudent.pictureBoxAvatar.ImageLocation
                };
                newStudent.Group = selectedGroup;

                try
                {
                    using (var fs = new FileStream(newStudent.Avatar, FileMode.Open))
                    {
                        newStudent.Image = new byte[fs.Length];
                        fs.Read(newStudent.Image, 0, newStudent.Image.Length);
                    }

                    db.Add(newStudent);
                    db.SaveChanges();
                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message, "Create Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Create Error Other", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadStudentToListBox();
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteStudent.Enabled = true;
           
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if(lstStudents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Нет выделенного студента");
                (sender as Button).Enabled = false;
                return;
            }
            List<Student> studentsToDel = new List<Student>();

            foreach (var item in lstStudents.SelectedItems)
            {
                studentsToDel.Add((Student)item);
                
            }

            foreach (var item in studentsToDel)
            {
                lstStudents.Items.Remove(item);
            }

            db.RemoveRange(studentsToDel);
            db.SaveChanges();
        }
    }
}
