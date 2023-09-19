using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using WinFormsAppRegister.Enums;
using WinFormsAppRegister.Models;

namespace WinFormsAppRegister
{
    public partial class RegisterForm : System.Windows.Forms.Form
    {
        List<UserData> users = null;
        List<AdminData> admins = null;
        public RegisterForm()
        {

            InitializeComponent();
            users = new List<UserData>()
            {
                new UserData { FirstName = "یاسمن", LastName = "حسین زاده", NationalCode = "2580083731", CellPhone = "09111364385", Gendar = Gender.Female, CreationDate = DateTime.Now },
                new UserData { FirstName = "زینب", LastName = "صادقی", NationalCode = "2580083731", CellPhone = "09111364385", Gendar = Gender.Female, CreationDate = DateTime.Now },
                new UserData { FirstName = "سمانه", LastName = "سالمی", NationalCode = "0012345698", CellPhone = "09123323232", Gendar = Gender.Female, CreationDate = DateTime.Now }
            };

            for (int i = 0; i < 100; i++)
            {
                users.Add(new UserData { FirstName = $"نام{i + 1}", LastName = $"نام خانوادگی{i + 1}", NationalCode = $"{1234567800}+{i + 1}", CellPhone = $"{09121234000}{i}", Gendar = Gender.Male, CreationDate = DateTime.Now });
            }

            PersonDataGridView.DataSource = users;
            PersonDataGridView.Columns[0].HeaderCell.Value = "نام";
            PersonDataGridView.Columns[1].HeaderCell.Value = "نام خانوادگی";
            PersonDataGridView.Columns[2].HeaderCell.Value = "شماره همراه";
            PersonDataGridView.Columns[3].HeaderCell.Value = "کد ملی";
            PersonDataGridView.Columns[4].HeaderCell.Value = "تاریخ ایجاد";
            PersonDataGridView.Columns[5].HeaderCell.Value = "جنسیت";


            admins = new List<AdminData>()
            {
                new AdminData { FirstName = "یاسمن", LastName = "حسین زاده", NationalCode = "2580083731", CellPhone = "09111364385", Gendar = Gender.Female, AccessId = 120, RoleName = "مدیر ارشد", CreationDate = DateTime.Now },
                new AdminData { FirstName = "مریم", LastName = "سمیعی", NationalCode = "2580083731", CellPhone = "09111364385", Gendar = Gender.Female, AccessId = 120, RoleName = "مدیر فنی", CreationDate = DateTime.Now }
            };

            AdminDataGridView.DataSource = admins;
            AdminDataGridView.Columns[0].HeaderCell.Value = "شناسه دسترسی";
            AdminDataGridView.Columns[1].HeaderCell.Value = "نقش";
            AdminDataGridView.Columns[2].HeaderCell.Value = "نام";
            AdminDataGridView.Columns[3].HeaderCell.Value = "نام خانوادگی";
            AdminDataGridView.Columns[4].HeaderCell.Value = "شماره همراه";
            AdminDataGridView.Columns[5].HeaderCell.Value = "کد ملی";
            AdminDataGridView.Columns[6].HeaderCell.Value = "تاریخ ایجاد";
            AdminDataGridView.Columns[7].HeaderCell.Value = "جنسیت";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ManagerSectiontextBox.Enabled = ManagerCodeTextBox.Enabled = false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            PersonData person = new PersonData();
            var isAdmin = isAdminCheckBox.Checked;

            person.FirstName = FirstNameTextBox.Text;
            person.LastName = LastNametextBox.Text;
            person.CellPhone = CellphoneTextBox.Text;
            person.NationalCode = NationalcodetextBox.Text;
            person.CreationDate = DateTime.Now;


            if (!person.IsInformationIsNullOrEmpty())
            {
                return;
            }

            person.CellPhone = person.CellPhone.ReplacePersianAndArabicNumbers();

            person.CellPhone = person.CellPhone.ValidateCellPhone();
            if (string.IsNullOrEmpty(person.CellPhone))
            {
                return;
            }
            if (!person.NationalCode.IsNationalCodeValid())
            {
                return;
            }



            person.Gendar = FemaleradioButton.Checked ? Gender.Female : Gender.Male;

            if (isAdmin)
            {
                AdminData admin = new AdminData()
                {
                    CellPhone = person.CellPhone,
                    FirstName = person.FirstName,
                    Gendar = person.Gendar,
                    LastName = person.LastName,
                    NationalCode = person.NationalCode,
                    CreationDate = DateTime.Now,

                };
                admin.RoleName = ManagerSectiontextBox.Text;
                admin.AccessId = (int)ManagerCodeTextBox.Value;

                admins.Add(admin);
                AdminDataGridView.DataSource = null;
                AdminDataGridView.DataSource = admins;
                AdminDataGridView.Refresh();
            }
            else
            {
                UserData user = new UserData()
                {
                    CellPhone = person.CellPhone,
                    FirstName = person.FirstName,
                    Gendar = person.Gendar,
                    LastName = person.LastName,
                    NationalCode = person.NationalCode
                };
                users.Add(user);

                PersonDataGridView.DataSource = null;
                PersonDataGridView.DataSource = users;
                PersonDataGridView.Refresh();
            }

            ClearForm();
        }

        private void isAdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ManagerSectiontextBox.Enabled = ManagerCodeTextBox.Enabled = isAdminCheckBox.Checked;
        }

        private void ClearForm()
        {
            ManagerSectiontextBox.Text = ManagerCodeTextBox.Text = FirstNameTextBox.Text = LastNametextBox.Text = CellphoneTextBox.Text = NationalcodetextBox.Text = string.Empty;
            FemaleradioButton.Checked = MaleradioButton.Checked = isAdminCheckBox.Checked = false;
        }
    }
}
