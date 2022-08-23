using DataLayer.Contracts;
using DataLayer.Models;
using WinForm.Infrastructure;

namespace WinForm
{
    public partial class FormAddContact : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormAddContact(
            IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CheckedFullNameIsBlank();
                CheckedMobileIsBlank();
                CheckedMobileIsDuplicate();

                var newImageName = SaveImage();
                var contact = FillContact(newImageName);

                _unitOfWork.ContactGenericRepository.Add(contact);
                _unitOfWork.Save();

                MessageBoxFactory.Successful();
                DialogResult = DialogResult.OK;
            }
            catch (FullNameRequiredException)
            {
                MessageBoxFactory.Required(gbFullName.Text);
            }
            catch (MobileRequiredException)
            {
                MessageBoxFactory.Required(gbMobile.Text);
            }
            catch (MobileIsDuplicatedException)
            {
                MessageBoxFactory.Duplicate(gbMobile.Text);
            }
            catch
            {
                MessageBoxFactory.Error();
            }

        }

        private void CheckedMobileIsDuplicate()
        {
            if (_unitOfWork.ContactRepository.IsExistMobile(tbMobile.Text.Trim()))
                throw new MobileIsDuplicatedException();
        }

        private void CheckedMobileIsBlank()
        {
            if (tbMobile.Text.IsBlank())
            {
                throw new MobileRequiredException();
            }
        }

        private void CheckedFullNameIsBlank()
        {
            if (tbFullName.Text.IsBlank())
            {
                throw new FullNameRequiredException();
            }
        }

        private Contact FillContact(string? newImageName)
        {
            return new Contact
            {
                FullName = tbFullName.Text,
                Mobile = tbMobile.Text,
                Email = tbEmail.Text,
                Instagram = tbInstagram.Text,
                Description = tbDescription.Text,
                ImageName = newImageName
            };
        }

        private string? SaveImage()
        {
            string? newImageName = null;
            if (!pbImage.ImageLocation.IsBlank())
            {
                newImageName = Guid.NewGuid().ToString() +
                       FileUtils.GetExtension(pbImage.ImageLocation);
                var imagePath = ApplicationPath.ImagePath();

                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }

                pbImage.Image.Save(imagePath + newImageName);
            }

            return newImageName;
        }

        private void btnPictureSelection_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = openFile.FileName;
            }
        }
    }
}
