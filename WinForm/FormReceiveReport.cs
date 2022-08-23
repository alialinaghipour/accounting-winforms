using DataLayer.Contracts;
using DataLayer.Models;
using DataLayer.ViewModels;
using System.Text;
using WinForm.Infrastructure;
using WinForm.Infrastructure.Convartor;

namespace WinForm
{
    public partial class FormReceiveReport : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private const string MaskedTextBoxFormat = "    /  /";


        public FormReceiveReport(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
        }

        private void FormReceiveReport_Load(object sender, EventArgs e)
        {
            var cbList = new List<GetAllNameContactViewModel>();
            var contactsName = GetAllContactsName();
            cbList.Add(new GetAllNameContactViewModel
            {
                Id = 0,
                FullName = "انتخاب کنید"
            });
            cbList.AddRange(contactsName);

            cbContactsName.DataSource = cbList;
            cbContactsName.DisplayMember = "FullName";
            cbContactsName.ValueMember = "Id";

            Filter();
        }

        private IList<GetAllNameContactViewModel> GetAllContactsName(string? search = null)
        {
            return unitOfWork.ContactRepository.GetAllNames(search);
        }

        void Filter()
        {
            var accountings = new List<Accounting>();

            if ((int)cbContactsName.SelectedValue != 0)
            {
                int contactId = Convert.ToInt32(cbContactsName.SelectedValue.ToString());
                var result = unitOfWork.AccountingRepository
                    .GetAll(_ => _.Type == AccountingType.Recive &&
                    _.ContactId == contactId);
                accountings.AddRange(result);
            }
            else
            {
                var result = unitOfWork.AccountingRepository
                    .GetAll(_ => _.Type == AccountingType.Recive);
                accountings.AddRange(result);
            }

            if (mtbStartDate.Text != MaskedTextBoxFormat)
            {
                accountings = FilterByStartDate(accountings);
            }
            if (mtbEndDate.Text != MaskedTextBoxFormat)
            {
                accountings = FilterByEndDate(accountings);
            }

            dgvReport.Rows.Clear();
            foreach (var accounting in accountings)
            {
                var contactName = unitOfWork.ContactRepository.GetNameById(accounting.ContactId);
                dgvReport.Rows.Add(
                    accounting.Id,
                    contactName!.FullName,
                    accounting.Amount.ToString("0,#"),
                    accounting.CreationDate.ToShamsi(),
                    accounting.Description);
            }
        }

        private List<Accounting> FilterByStartDate(List<Accounting> accountings)
        {
            var startDate = Convert.ToDateTime(mtbStartDate.Text);
            startDate = startDate.ToMiladi();
            return accountings = accountings
                .Where(_ => _.CreationDate.Date >= startDate.Date)
                .ToList();
        }

        private List<Accounting> FilterByEndDate(List<Accounting> accountings)
        {
            var endDate = Convert.ToDateTime(mtbEndDate.Text);
            endDate = endDate.ToMiladi();
            return accountings = accountings
                .Where(_ => _.CreationDate.Date <= endDate.Date)
                .ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                string name = dgvReport.CurrentRow.Cells[1].Value.ToString()!;
                var id = Convert.ToInt32(dgvReport.CurrentRow.Cells[0].Value.ToString());
                var text = new StringBuilder()
                    .Append("آیا از حذف تراکنش")
                    .Append(" " + name)
                    .Append("مطمئن هستید ؟")
                    .ToString();
                DialogResult message = MessageBoxFactory.Warning(text);

                if (message == DialogResult.Yes)
                {
                    var accounting = unitOfWork.AccountingRepository.GetById(id);
                    unitOfWork.AccountingRepository.Remove(accounting!);
                    unitOfWork.Save();
                    Filter();
                }
            }
            MessageBoxFactory.Error("لطفا شخصی را انتخاب کنید");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDateTiemNow_Click(object sender, EventArgs e)
        {
            mtbEndDate.Text = DateTime.Now.ToShamsi();
        }

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var frmEditTransaction = new FormUpdateTransaction(unitOfWork);
            if (dgvReport.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvReport.CurrentRow.Cells[0].Value.ToString());
                frmEditTransaction.AccountingId = id;
                if (frmEditTransaction.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
            else
            {
                MessageBoxFactory.Warning("لطفا شخصی را انتخاب کنید");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
