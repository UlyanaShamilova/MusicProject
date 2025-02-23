using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicProject
{
    public partial class FormGallery : Form
    {
        private string ImageTitleFileName = "titles.csv";
        private IEnumerable<Photo> _photos;

        int selectedPhotoIndex = 0;
        int shownPhotosMinIndex = 0;
        int shownPhotosMaxIndex = 0;
        int photosMaxIndex = 0;

        private int curiPhoto = 0;
        private bool isSlideShow = false;
        public FormGallery()
        {
            InitializeComponent();
        }

        private string GetAssetsFolderPath()
        {
            return Path.Combine(Application.StartupPath, "Assets");
        }

        private void FormGallery_Load(object sender, EventArgs e)
        {
            LoadPhotos();
            InitializePictureBoxes();
        }

        private void LoadPhotos()
        {
            var assetsFolderPath = GetAssetsFolderPath();
            var imageTitlesFilePath = Path.Combine(assetsFolderPath, ImageTitleFileName);

            var imageTitles = File.ReadAllLines(imageTitlesFilePath);

            var photos = new List<Photo>();

            foreach (var title in imageTitles)
            {
                var photo = new Photo(title);
                photos.Add(photo);
            }

            _photos = photos;
            photosMaxIndex = _photos.Count() - 1;
        }

        private void InitializePictureBoxes()
        {
            UpdateMainPictureBox();
            shownPhotosMaxIndex = _photos.Count() > 5 ? 4 : _photos.Count() - 1;

            UpdatePictureBoxes();
        }

        private void UpdatePictureBoxes()
        {
            var pictureBoxes = new List<PictureBox>
            {
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6
            };

            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                var photoIndex = i + shownPhotosMinIndex;
                if (photoIndex > shownPhotosMaxIndex)
                    break;

                var imagePath = _photos.ElementAt(photoIndex).ImagePath;

                pictureBoxes[i].Load(imagePath);
            }
        }

        private void UpdateMainPictureBox()
        {
            var mainImage = _photos.ElementAt(selectedPhotoIndex);

            pictureBoxMain.Load(mainImage.ImagePath);
            label1.Text = mainImage.Title;
        }

        private void MovePhotosRight()
        {
            if (shownPhotosMaxIndex == photosMaxIndex)
                return;

            shownPhotosMinIndex++;
            shownPhotosMaxIndex++;
            UpdatePictureBoxes();
        }

        private void MovePhotosLeft()
        {
            if (shownPhotosMaxIndex == photosMaxIndex)
                return;

            shownPhotosMinIndex--;
            shownPhotosMaxIndex--;
            UpdatePictureBoxes();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (selectedPhotoIndex < photosMaxIndex)
            {
                pictureBox1.Image = Properties.Resources.chevron_right_1;
                pictureBox1.Cursor = Cursors.Hand;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.chevron_right_2;
                pictureBox1.Cursor = Cursors.No;
            }

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (selectedPhotoIndex < photosMaxIndex)
                pictureBox1.Image = Properties.Resources.chevron_right_1;
            else
                pictureBox1.Image = Properties.Resources.chevron_right_2;

            pictureBox1.Cursor = Cursors.Default;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            selectedPhotoIndex++;

            if (selectedPhotoIndex > photosMaxIndex)
                return;

            UpdateMainPictureBox();

            if (selectedPhotoIndex > shownPhotosMaxIndex)
                MovePhotosRight();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectedPhotoIndex = shownPhotosMinIndex;

            UpdateMainPictureBox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var updatedPhotoIndex = shownPhotosMinIndex + 1;
            if (updatedPhotoIndex > photosMaxIndex)
                return;

            selectedPhotoIndex = updatedPhotoIndex;

            UpdateMainPictureBox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var updatedPhotoIndex = shownPhotosMinIndex + 2;
            if (updatedPhotoIndex > photosMaxIndex)
                return;

            selectedPhotoIndex = updatedPhotoIndex;

            UpdateMainPictureBox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var updatedPhotoIndex = shownPhotosMinIndex + 3;
            if (updatedPhotoIndex > photosMaxIndex)
                return;

            selectedPhotoIndex = updatedPhotoIndex;

            UpdateMainPictureBox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var updatedPhotoIndex = shownPhotosMinIndex + 4;
            if (updatedPhotoIndex > photosMaxIndex)
                return;

            selectedPhotoIndex = updatedPhotoIndex;

            UpdateMainPictureBox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (selectedPhotoIndex == 0) // Проверка, не уходим ли за пределы
                return;

            selectedPhotoIndex--; // Уменьшаем индекс

            UpdateMainPictureBox(); // Обновляем главное изображение

            if (selectedPhotoIndex < shownPhotosMinIndex) // Если зашли за границу отображаемых фото
                MovePhotosLeft();
        }

        private void SlideShow_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_photos?.Any() != true) return;
            pictureBoxMain.Load(_photos.ElementAt(++curiPhoto % _photos.Count()).ImagePath);
        }
    }
}
