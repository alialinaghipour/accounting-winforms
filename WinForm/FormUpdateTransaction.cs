using DataLayer.Contracts;
using DataLayer.Models;
using WinForm.Infrastructure;

namespace WinForm
{
    public partial class FormUpdateTransaction : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private bool _isRecive;
        public int AccountingId;

        public FormUpdateTransaction(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            GetAllContactNames(tbSearch.Text);
        }

        private void GetAllContactNames(string? search = null)
        {
            dgvContactsName.DataSource = _unitOfWork.ContactRepository.GetAllNames(search);

        }

        private void FormUpdateTransaction_Load(object sender, EventArgs e)
        {
            try
            {
                if (AccountingId == 0)
                    throw new AccountingIdEmptyException();

                var accounting = _unitOfWork.AccountingRepository.GetById(AccountingId);

                if (accounting == null)
                    throw new AccountingNotFoundException();

                var contactName = _unitOfWork.ContactRepository.GetNameById(accounting.ContactId);
                tbName.Text = contactName!.FullName;

                tnAmount.Value = accounting.Amount;
                tbDescription.Text = accounting.Description;

                if (accounting.Type == AccountingType.Pay)
                    rbPay.Checked = true;
                else
                    rbRecive.Checked = true;

                GetAllContactNames();
            }
            catch
            {
                MessageBoxFactory.Error();
            }
            GetAllContactNames();

            if (_isRecive)
                rbRecive.Checked = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbRecive.Checked)
            {
                try
                {
                    var contactId = Convert.ToInt32(dgvContactsName.CurrentRow.Cells[0].Value.ToString());
                    var accountingType = AccountingType.Recive;
                    var accounting = new Accounting
                    {
                        Amount = (int)tnAmount.Value,
                        ContactId = contactId,
                        Type = accountingType,
                        Description = tbDescription.Text,
                        CreationDate = DateTime.Now,
                    };

                    _unitOfWork.AccountingRepository.Add(accounting);
                    _unitOfWork.Save();
                    MessageBoxFactory.Successful();
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBoxFactory.Error();
                }
            }
        }

        public void IsRecive(bool value = false)
        {
            _isRecive = value;
        }

        private void dgvContactsName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbName.Text = dgvContactsName.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
