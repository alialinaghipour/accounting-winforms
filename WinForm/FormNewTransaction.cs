using DataLayer.Contracts;
using DataLayer.Models;
using WinForm.Infrastructure;

namespace WinForm
{
    public partial class FormNewTransaction : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private bool _isPayment;
        private bool _isRecive;

        public FormNewTransaction(IUnitOfWork unitOfWork)
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

        private void FormNewTransaction_Load(object sender, EventArgs e)
        {
            GetAllContactNames();

            if (_isPayment)
                rbPay.Checked = true;
            if (_isRecive)
                rbRecive.Checked = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbPay.Checked || rbRecive.Checked)
            {
                try
                {
                    var contactId = Convert.ToInt32(dgvContactsName.CurrentRow.Cells[0].Value.ToString());
                    var accountingType = rbRecive.Checked ? AccountingType.Recive : AccountingType.Pay;
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

        public void IsPayment(bool value = false)
        {
            _isPayment = value;
        }

        public void IsRecive(bool value = false)
        {
            _isRecive = value;
        }

        private void dgvContactsName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbName.Text = dgvContactsName.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvContactsName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
