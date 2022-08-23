using DataLayer.Contracts;
using DataLayer.Models;
using System.Globalization;
using WinForm.Infrastructure.Convartor;

namespace WinForm
{
    public partial class FormAccounting : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormAccounting(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            var formNewTransaction = new FormNewTransaction(_unitOfWork);
            formNewTransaction.IsPayment(true);
            if (formNewTransaction.ShowDialog() == DialogResult.OK)
            {
                FormLoadWithReport();
            }
        }

        private void btnListReceive_Click(object sender, EventArgs e)
        {
            var formReceiveReport = new FormReceiveReport(_unitOfWork);
            if (formReceiveReport.ShowDialog() == DialogResult.OK)
            {
                FormLoadWithReport();
            }
        }

        private void btnListPayment_Click(object sender, EventArgs e)
        {
            var formPaymentReport = new FormPaymentReport(_unitOfWork);
            if (formPaymentReport.ShowDialog() == DialogResult.OK)
            {
                FormLoadWithReport();
            }
        }

        private void FormAccounting_Load(object sender, EventArgs e)
        {
            FormLoadWithReport();
        }

        private void FormLoadWithReport()
        {
            mtbEndDate.Text = DateTime.Now.ToShamsi();
            mtbStartDate.Text = DateTime.Now.AddMonths(-1).ToShamsi();

            AccountingReport(DateTime.Now.AddMonths(-1), DateTime.Now);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var startDate = Convert.ToDateTime(mtbStartDate.Text);
            startDate = startDate.ToMiladi();
            var endDate = Convert.ToDateTime(mtbEndDate.Text);
            endDate = endDate.ToMiladi();
            AccountingReport(startDate, endDate);
        }

        private void AccountingReport(DateTime startDate, DateTime endDate)
        {
            var recive = _unitOfWork.AccountingRepository.GetAll(
                            _ => _.Type == AccountingType.Recive &&
                            _.CreationDate >= startDate &&
                            _.CreationDate <= endDate)
                            .Select(_ => _.Amount)
                            .ToList()
                            .Sum();

            var pay = _unitOfWork.AccountingRepository.GetAll(
                _ => _.Type == AccountingType.Pay &&
                _.CreationDate >= startDate &&
                _.CreationDate <= endDate)
                .Select(_ => _.Amount)
                .Sum();

            lblPayment.Text = pay.ToString("#,0");
            lblRevice.Text = recive.ToString("#,0");
            lblBalance.Text = (recive - pay).ToString("#,0");
        }

        private void btnDateTiemNow_Click(object sender, EventArgs e)
        {
            mtbEndDate.Text = DateTime.Now.ToShamsi();
        }
    }
}
