using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ef_design_first.DTOs;
using Ef_design_first.Service;
using Ef_design_first;
namespace WinFormGUI
{
    public partial class PhotoView : Form
    {
        IService Api = new Service();
        string pathAbs="";
        List<Photo> photos;
        public PhotoView()
        {
            InitializeComponent();
            ShowPhotosPanel.Hide();
            SavePhotoPanel.Show();
        }

        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
           
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pathAbs = opnfd.FileName;
                PictureCointainer.SizeMode = PictureBoxSizeMode.StretchImage;
                PictureCointainer.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void AddPropertyBtn_Click(object sender, EventArgs e)
        {
            if (PropertyInput.Text != "")
            {
                if (PropertiesCheckList.CheckedItems.Contains(PropertyInput.Text) == false)
                    PropertiesCheckList.Items.Add(PropertyInput.Text, CheckState.Checked);
                PropertyInput.Text = "";
            }
        }

        private void AddPeopleBtn_Click(object sender, EventArgs e)
        {
            if (NameInput.Text != "" && SurnameInput.Text!="")
            {
                if (PeopleCheckList.CheckedItems.Contains(NameInput.Text+ ' '+SurnameInput.Text) == false)
                    PeopleCheckList.Items.Add(NameInput.Text + ' ' + SurnameInput.Text, CheckState.Checked);
                NameInput.Text = "";
                SurnameInput.Text = "";
            }
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            pathAbs = "";
            PictureCointainer.Image = null;
            descriptionInput.Text = "";
            eventInput.Text = "";
            titleInput.Text = "";
            NameInput.Text = "";
            SurnameInput.Text = "";
            PropertyInput.Text = "";
            locationInput.Text = "";
        }

        private void savePhotoBtn_Click(object sender, EventArgs e)
        {
            if (pathAbs == "")
                MessageBox.Show("please choose a photo");
            else
            if (titleInput.Text=="")
                MessageBox.Show("please choose a title");
            else
            if (descriptionInput.Text == "")
                MessageBox.Show("please choose a description");
            else
            if (eventInput.Text == "")
                MessageBox.Show("please choose a event");
            else
            if (locationInput.Text == "")
                MessageBox.Show("please choose a location");

            PhotoDto newPhoto = new PhotoDto()
            {
                path = pathAbs,
                title = titleInput.Text,
                description = descriptionInput.Text,
                eveniment = eventInput.Text,
                date = photoDate.Value,
                location = locationInput.Text

            };
            IList<PersonDto> persons = new List<PersonDto>();
            if (PeopleCheckList.CheckedItems != null)
            {
                
                foreach (string person in PeopleCheckList.CheckedItems)
                {
                    string[] names = person.Split(' ');
                    persons.Add(new PersonDto()
                    {   
                        name=names[0],
                        surname=names[1]

                    });

                }
            }
            string other = "";
            if (PropertiesCheckList.CheckedItems != null)
            {
                
                foreach (string prop in PropertiesCheckList.CheckedItems)
                {
                    other += ";" + prop.ToUpper();
                }
            }
            Api.AddPhoto(newPhoto, other, persons);
            pathAbs = "";
            PictureCointainer.Image = null;
            descriptionInput.Text = "";
            eventInput.Text = "";
            titleInput.Text = "";
            NameInput.Text = "";
            SurnameInput.Text = "";
            PropertyInput.Text = "";
            locationInput.Text = "";
        }

        private void SavePhotoMenu_Click(object sender, EventArgs e)
        {
            SavePhotoPanel.Show();
            ShowPhotosPanel.Hide();


            
        }

        private void ViewPhotoMenu_Click(object sender, EventArgs e)
        {
            SavePhotoPanel.Hide();
            ShowPhotosPanel.Show();
            photos = Api.GetAll();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(150, 200);
          
            
            foreach (var item in photos)
            {
                MessageBox.Show(item.Titlu);
                listView1.Items.Add(new ListViewItem(item.Titlu, 0));
                imageList.Images.Add(Bitmap.FromFile(item.Path));

            }
            listView1.LargeImageList = imageList;


         
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string selected = listView1.SelectedItems[0].SubItems[0].Text;
            Photo selectedPhoto = photos.Find(photo => photo.Titlu == selected);
            titluLabel.Text = selectedPhoto.Titlu;
            locatieLabel.Text = selectedPhoto.Location.Name;
            descriptionBox.Text = selectedPhoto.Descriere;
            descriptionBox.Enabled = false;
            dataLabel.Text = selectedPhoto.Data.ToString();
            bigPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            bigPicture.Image = Bitmap.FromFile(selectedPhoto.Path);


        }
    }
}
