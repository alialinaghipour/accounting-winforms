using DataLayer.Contracts;
using WinForm.Infrastructure;

namespace WinForm
{
    public partial class frmProfile : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public frmProfile(
            IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            var profile = _unitOfWork.MyProfileRepository.Get();

            if (profile != null)
            {
                tbFullName.Text = profile.FullName;
                tbMobile.Text = profile.Mobile;
                tbInstageram.Text = profile.Instagram;
                tbDescription.Text = profile.Description;
                pbImage.ImageLocation = ApplicationPath.ImagePath() + profile.ImageName;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbFullName.Text.IsBlank())
                MessageBoxFactory.MessageRequired(gbFullName.Text);
            else if (tbMobile.Text.IsBlank())
                MessageBoxFactory.MessageRequired(gbMobile.Text);

            var profile = _unitOfWork.MyProfileRepository.Get();

            if (profile != null)
            {
                string? newImageName = null;
                if (!profile!.ImageName.IsBlank())
                {
                    var imagePath = ApplicationPath.ImagePath();
                    var oldImage = imagePath + profile.ImageName;
                    FileUtils.Delete(oldImage);

                    newImageName = Guid.NewGuid().ToString() +
                        FileUtils.GetExtension(pbImage.ImageLocation);

                    if (!Directory.Exists(imagePath))
                    {
                        Directory.CreateDirectory(imagePath);
                    }

                    pbImage.Image.Save(imagePath + newImageName);
                }

                profile.FullName = tbFullName.Text;
                profile.Mobile = tbMobile.Text;
                profile.Instagram = tbInstageram.Text;
                profile.Description = tbDescription.Text;
                profile.ImageName = newImageName;

                _unitOfWork.Save();
                MessageBoxFactory.MessageSuccessful("عملیات موفقیت آمیز بود");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBoxFactory.MessageError("مشکلی پیش آمده است");
            }

        }



        private void btnPictureSelection_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = openFile.FileName;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
