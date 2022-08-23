using DataLayer.Contracts;
using DataLayer.Models;
using WinForm.Infrastructure;

namespace WinForm
{
    public partial class frmContacts : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public frmContacts(
            IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void frmContacts_Load(object sender, EventArgs e)
        {
            GetAllContacts();
        }

        private void GetAllContacts()
        {
            var contacts = _unitOfWork.ContactGenericRepository.GetAll();
            dgvContacts.AutoGenerateColumns = false;
            dgvContacts.DataSource = contacts;
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow != null)
            {
                var formUpdate = new FormUpdateContact(_unitOfWork);
                var id = Convert.ToInt32(dgvContacts.CurrentRow.Cells[0].Value.ToString());
                formUpdate.ContactId = id;
                if (formUpdate.ShowDialog() == DialogResult.OK)
                {
                    GetAllContacts();
                }

            }
            else
                MessageBoxFactory.Error("حتما باید یکی را انتخاب کنید");
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            var formAdd = new FormAddContact(_unitOfWork);
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                GetAllContacts();
            }
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow != null)
            {
                var name = dgvContacts.CurrentRow.Cells[1].Value.ToString();
                var id = Convert.ToInt32(dgvContacts.CurrentRow.Cells[0].Value.ToString());

                DialogResult message = MessageBoxFactory.Warning(name!);
                if (message == DialogResult.Yes)
                {
                    var contact = _unitOfWork.ContactGenericRepository.GetById(id)!;
                    DeletedImage(contact);
                    _unitOfWork.ContactGenericRepository.Remove(contact);
                    _unitOfWork.Save();
                    GetAllContacts();
                }
            }
            else
            {
                MessageBoxFactory.Error("لطفا شخصی را انتخاب کنید");
            }
        }

        private static void DeletedImage(Contact contact)
        {
            if (!contact.ImageName.IsBlank())
            {
                var imgName = contact.ImageName;
                string path = ApplicationPath.ImagePath() + imgName;
                FileUtils.Delete(path);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgvContacts.DataSource = _unitOfWork.ContactRepository.GetAll(tbSearch.Text);
        }

        private void tbRefresh_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            GetAllContacts();
        }
    }
}
