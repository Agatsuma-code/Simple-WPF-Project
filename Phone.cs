using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.Entity;
using PhoneBook.Models;

namespace PhoneBook {
    public partial class Phone : MetroFramework.Forms.MetroForm {
        public Phone() {
            InitializeComponent();
        }
        #region Extra Stuff
        //private void btnBrowse_Click(object sender, EventArgs e) {
        //    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*jpg" }) {
        //        if (ofd.ShowDialog() == DialogResult.OK) {
        //            picture.Image = Image.FromFile(ofd.FileName);
        //            Contact obj = contactBindingSource.Current as Contact;
        //            if (obj != null) {
        //                obj.ImageUrl = ofd.FileName;
        //            }
        //        }
        //    }


        //}

        //private void Form1_Load(object sender, EventArgs e) {
        //    using (ModelContext db = new ModelContext()) {
        //        contactBindingSource.DataSource = db.Contacts.ToList();
        //    }
        //    metroPanel.Enabled = false;
        //    Contact obj = contactBindingSource.Current as Contact;
        //    if (obj != null) {
        //        picture.Image = Image.FromFile(obj.ImageUrl);
        //    }
        //}

        //private void btnAdd_Click(object sender, EventArgs e) {
        //    picture.Image = null;
        //    metroPanel.Enabled = true;
        //    contactBindingSource.Add(new Contact());
        //    contactBindingSource.MoveLast();
        //    txtName.Focus();
        //}

        //private void btnEdit_Click(object sender, EventArgs e) {
        //    metroPanel.Enabled = true;
        //    txtName.Focus();
        //    Contact obj = contactBindingSource.Current as Contact;
        //}

        //private void btnCancle_Click(object sender, EventArgs e) {
        //    metroPanel.Enabled = false;
        //    contactBindingSource.ResetBindings(false);
        //    Form1_Load(sender, e);

        //}

        //private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
        //    Contact obj = contactBindingSource.Current as Contact;
        //    if (obj != null) {
        //        picture.Image = Image.FromFile(obj.ImageUrl);
        //    }
        //}
        //Contact Delete Button
        //private void btnDelete_Click(object sender, EventArgs e) {
        //    if (MetroFramework.MetroMessageBox.Show(this, " Are You Sure To Delete This Record? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
        //        using (ModelContext db = new ModelContext()) {
        //            Contact obj = contactBindingSource.Current as Contact;
        //            if (obj != null) {
        //                if (db.Entry<Contact>(obj).State == EntityState.Detached)
        //                    db.Set<Contact>().Attach(obj);
        //                db.Entry<Contact>(obj).State = EntityState.Deleted;
        //                db.SaveChanges();
        //                MetroFramework.MetroMessageBox.Show(this, "Deleted Successfully");
        //                contactBindingSource.RemoveCurrent();
        //                metroPanel.Enabled = false;
        //                picture.Image = null;
        //            }
        //        }
        //    }
        //}
        //Contact Saving Button
        //private void btnSave_Click(object sender, EventArgs e) {
        //    using (ModelContext db = new ModelContext()) {
        //        Contact obj = contactBindingSource.Current as Contact;
        //        if (obj != null) {
        //            if (db.Entry<Contact>(obj).State == EntityState.Detached)
        //                db.Set<Contact>().Attach(obj);
        //            if (obj.Id == 0)
        //                db.Entry<Contact>(obj).State = EntityState.Added;
        //            else
        //                db.Entry<Contact>(obj).State = EntityState.Modified;
        //            db.SaveChanges();
        //            MetroFramework.MetroMessageBox.Show(this, "Save Successfully");
        //            metroGrid.Refresh();
        //            metroPanel.Enabled = false;
        //        }
        //    }
        //}

        #endregion
        //Image Browse Button
        private void picture_Click(object sender, EventArgs e) {
           
        }
        private void ButtonBrowse_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*jpg" }) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    picture.Image = Image.FromFile(ofd.FileName);
                    Contact obj = bindingSource2.Current as Contact;
                    if (obj == null) {
                        obj.ImageUrl = ofd.FileName;
                    }
                }
                {

                }
            }
        }

        //Page Load Form
        private void PhoneBook_Load(object sender, EventArgs e) {
            using (ModelContext db = new ModelContext()) {
                //bindingSource1.DataSource = db.ContactList.ToList();
                bindingSource2.DataSource = db.ContactList.ToList();
            }
            metroPanel1.Enabled = false;
            Contact obj = bindingSource2.Current as Contact;
            if (obj != null) {
                picture.Image = Image.FromFile(obj.ImageUrl);
            }
        }

        //Add Contact Button
        private void AddButton_Click(object sender, EventArgs e) {
            picture.Image = null;
            metroPanel1.Enabled = true;
            bindingSource2.Add(new Contact());
            bindingSource2.MoveLast();
            TEXTNAME.Focus();
        }

        //Edit Contact Button
        private void EditButton_Click(object sender, EventArgs e) {
            metroPanel1.Enabled = true;
            TEXTNAME.Focus();
            Contact obj = bindingSource2.Current as Contact;
        }

        //Cancle Edition Contact Button
        private void CancleButton_Click(object sender, EventArgs e) {
            metroPanel1.Enabled = false;
            bindingSource2.ResetBindings(false);
            PhoneBook_Load(sender, e);
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e) {
            Contact obj = bindingSource2.Current as Contact;
            if (obj != null) {
                picture.Image = Image.FromFile(obj.ImageUrl);
            }
        }

        //Delete Contact Record
        private void DeleteButton_Click(object sender, EventArgs e) {
            if (MetroFramework.MetroMessageBox.Show(this, " Are You Sure To Delete This Record? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                using (ModelContext db = new ModelContext()) {
                    Contact obj = bindingSource2.Current as Contact;
                    if (obj != null) {
                        if (db.Entry<Contact>(obj).State == EntityState.Detached)
                            db.Set<Contact>().Attach(obj);
                        db.Entry<Contact>(obj).State = EntityState.Deleted;
                        db.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Deleted Successfully");
                        bindingSource2.RemoveCurrent();
                        metroPanel1.Enabled = false;
                        picture.Image = null;
                    }
                }
            }
        }

        //Save Contact 
        private void SaveButton_Click(object sender, EventArgs e) {
            using (ModelContext db = new ModelContext()) {
                Contact obj = bindingSource2.Current as Contact;
                if (obj != null) {
                    if (db.Entry<Contact>(obj).State == EntityState.Detached)
                        db.Set<Contact>().Attach(obj);
                    if (obj.Id == 0)
                        db.Entry<Contact>(obj).State = EntityState.Added;
                    else
                        db.Entry<Contact>(obj).State = EntityState.Modified;
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Save Successfully");
                    metroGrid1.Refresh();
                    metroPanel1.Enabled = false;
                }
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e) {

        }

    }
}
