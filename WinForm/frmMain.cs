using DataLayer.Contracts;

namespace WinForm
{
    public partial class frmMain : Form
    {
        private readonly frmProfile _frmProfile;
        private readonly IUnitOfWork _unitOfWork;
        private readonly FormAddContact formAddContact;
        private readonly FormUpdateContact formUpdateContact;
        private readonly frmContacts frmContacts;
        private readonly FormAccounting formAccounting;

        public frmMain(
            frmProfile frmProfile,
            IUnitOfWork unitOfWork,
            FormAddContact formAddContact,
            FormUpdateContact formUpdateContact,
            frmContacts frmContacts,
            FormAccounting formAccounting)
        {

            InitializeComponent();
            _frmProfile = frmProfile;
            _unitOfWork = unitOfWork;
            this.formAddContact = formAddContact;
            this.formUpdateContact = formUpdateContact;
            this.frmContacts = frmContacts;
            this.formAccounting = formAccounting;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            _frmProfile.ShowDialog();
        }

        private void btnListConatcts_Click(object sender, EventArgs e)
        {
            frmContacts.ShowDialog();
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            formAccounting.ShowDialog();
        }

        private void timerDateTimeNow_Tick(object sender, EventArgs e)
        {
            lblDateTimeNow.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
