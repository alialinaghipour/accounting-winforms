using DataLayer.Contracts;
using DataLayer.Models;
using WinForm.Infrastructure;

namespace WinForm
{
    public partial class FormUpdateContact : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public int ContactId;

        public FormUpdateContact(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void FormUpdateContact_Load(object sender, EventArgs e)
        {

            try
            {
                var contact = GetContact();
                CheckedContactNotFound(contact);

                tbFullName.Text = contact!.FullName;
                tbMobile.Text = contact!.Mobile;
                tbEmail.Text = contact!.Email;
                tbDescription.Text = contact!.Description;
                tbInstagram.Text = contact!.Instagram;
                pbImage.ImageLocation = ApplicationPath.ImagePath() + contact!.ImageName;

            }
            catch (ContactNotFoundException)
            {
                MessageBoxFactory.Error();
            }

        }

        private static void CheckedContactNotFound(Contact? contact)
        {
            if (contact == null)
                throw new ContactNotFoundException();
        }

        private Contact? GetContact()
        {
            return _unitOfWork.ContactGenericRepository.GetById(ContactId);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CheckedFullNameIsBlank();
                CheckedMobileIsBlank();
                CheckedMobileIsDuplicate(ContactId);

                var contact = GetContact()!;
                CheckedContactNotFound(contact);

                DeletedImage(contact.ImageName);
                var newImageName = SaveImage();
                FillContant(contact, newImageName);

                _unitOfWork.ContactGenericRepository.Update(contact);
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
            catch (ContactNotFoundException)
            {
                MessageBoxFactory.Error();
            }
            catch
            {
                MessageBoxFactory.Error();
            }

        }

        private void CheckedMobileIsDuplicate(int id)
        {
            if (_unitOfWork.ContactRepository.IsExistMobile(tbMobile.Text.Trim(),id))
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

        private void FillContant(Contact contact, string? newImageName)
        {
            contact.FullName = tbFullName.Text;
            contact.Mobile = tbMobile.Text;
            contact.Email = tbEmail.Text;
            contact.Description = tbDescription.Text;
            contact.Instagram = tbInstagram.Text;
            contact.ImageName = newImageName;
        }

        private string? SaveImage()
        {
            string? newImageName = null;
            if (!pbImage.ImageLocation.IsBlank())
            {
                var imagePath = ApplicationPath.ImagePath();
                newImageName = Guid.NewGuid().ToString() +
                    FileUtils.GetExtension(pbImage.ImageLocation);

                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }

                pbImage.Image.Save(imagePath + newImageName);
            }

            return newImageName;
        }

        private static void DeletedImage(string? imageName)
        {
            if (!imageName.IsBlank())
            {
                var imagePath = ApplicationPath.ImagePath();
                var oldImage = imagePath + imageName;
                FileUtils.Delete(oldImage);
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
    }
}
